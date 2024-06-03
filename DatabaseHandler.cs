using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Security.Principal;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryGUI
{
    //Database entry not managed efficiently, was having issues with sharing connections between methods and had no time to troubleshoot
    //Shouldn't be an issue for testing, but will scale very poorly, needs significant work to fix (sharing connections, combining multiple entries into transactions etc.)
    internal class DatabaseHandler
    {
        //## Fields ##
        private static string resourcePath = @"../../../Resources";
        //Password Database
        private static string passDBName = "passwd.db3";
        private static string passDBPath = Path.Combine(resourcePath, passDBName);
        private static string mainDBName = "library.db3";
        private static string mainDBPath = Path.Combine(resourcePath, mainDBName);
        //## Methods ##
        private static string ConnectionString(string databasePath) //return connection string for given database
        {
            return $"Data Source={databasePath}; Version=3;";
        }

        //Database Generation
        public static void CreateDB(string DBPath)
        {
            SQLiteConnection.CreateFile(DBPath);
        }
        public static void CreatePasswordTable()
        {
            using var connection = new SQLiteConnection(ConnectionString(passDBPath));
            {
                connection.Open();
                string tableString = "CREATE TABLE IF NOT EXISTS passwords(Username varchar(24) UNIQUE NOT NULL, Hash varchar(44) NOT NULL, Salt varchar(44) NOT NULL, Email varchar(254) NOT NULL, AccountID INT NOT NULL, Admin INT NOT NULL)";
                var create = new SQLiteCommand(tableString, connection);
                create.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void CreateLibraryTable()
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                connection.Open();
                string tableString = "CREATE TABLE IF NOT EXISTS Library(PenaltyRate INT NOT NULL, BorrowLength INT NOT NULL, MaxRenewals INT NOT NULL, LastOverdueCheck VARCHAR(25) NOT NULL, NextStudentID INT NOT NULL, NextStaffID INT NOT NULL, NextItemID INT NOT NULL, BorrowValues VARCHAR)";
                var create = new SQLiteCommand(tableString, connection);
                create.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void CreateUsersTable()
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                connection.Open();
                string tableString = "CREATE TABLE IF NOT EXISTS Users(ID INT UNIQUE NOT NULL, FirstName VARCHAR NOT NULL, LastName VARCHAR NOT NULL, FeesOwed INT NOT NULL, BorrowCount INT NOT NULL, Username VARCHAR(24))";
                var create = new SQLiteCommand(tableString, connection);
                create.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void CreateMediaItemsTable()
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                connection.Open();
                string tableString = "CREATE TABLE IF NOT EXISTS MediaItem(ID INT UNIQUE NOT NULL, IsDigital INT NOT NULL, ISBN VARCHAR(20) NOT NULL, InitialCheckOutDate VARCHAR(25) NOT NULL, ReturnDate VARCHAR(25) NOT NULL, BorrowerID INT NOT NULL)";
                var create = new SQLiteCommand(tableString, connection);
                create.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void CreateMediaInfoTable()
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                connection.Open();
                string tableString = "CREATE TABLE IF NOT EXISTS MediaInfo(ISBN VARCHAR(20) UNIQUE NOT NULL, Authors TEXT NOT NULL, Title VARCHAR NOT NULL, Description TEXT NOT NULL)";
                var create = new SQLiteCommand(tableString, connection);
                create.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void ReplacePasswordTable(bool confirm) //compeltely wipe passwords table and replace with empty. used for testing purposes.
        {
            if (!confirm)
            {
                throw new ArgumentException("Table Replacement not confirmed. Did you mean to use CreatePasswordTable()");
            }
            else
            {
                using var connection = new SQLiteConnection(ConnectionString(passDBPath));
                {
                    connection.Open();
                    string dropString = "DROP TABLE IF EXISTS passwords;";
                    var drop = new SQLiteCommand(dropString, connection);
                    drop.ExecuteNonQuery();
                    string tableString = "CREATE TABLE IF NOT EXISTS passwords(Username varchar(24) UNIQUE NOT NULL, Hash varchar(44) NOT NULL, Salt varchar(44) NOT NULL, Email varchar(254) NOT NULL, AccountID INT NOT NULL, Admin INT NOT NULL)";
                    var create = new SQLiteCommand(tableString, connection);
                    create.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        //Database Initialization
        public static void InitializeDatabase()
        {
            if (!Directory.Exists(resourcePath))
            {
                Directory.CreateDirectory(resourcePath);
            }
            if (!File.Exists(passDBPath))
            {
                SQLiteConnection.CreateFile(passDBPath);
            }
            if (!File.Exists(mainDBPath))
            {
                SQLiteConnection.CreateFile(mainDBPath);
            }
            CreatePasswordTable();
            CreateLibraryTable();
            CreateUsersTable();
            CreateMediaItemsTable();
            CreateMediaInfoTable();
        }
        //Account Data
        public static bool AccountExists(string username)
        {
            using var connection = new SQLiteConnection(ConnectionString(passDBPath));
            {
                try
                {
                    connection.Open();
                    string existsQuery = "SELECT EXISTS (SELECT 1 FROM passwords WHERE LOWER(Username) = LOWER(@Username))";
                    SQLiteCommand exists = new SQLiteCommand(existsQuery, connection);
                    exists.Parameters.AddWithValue("@Username", username);
                    return Convert.ToBoolean(exists.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    ErrorHandler error = new();
                    error.Add($"Something went wrong checking the database. This error should not occur. Caused by: \n{ex.Message}", "Error Checking if Account Exists");
                    error.Display();
                    throw new Exception("Account Check Exception - Data can not be verified, unsafe to continue");
                }
                finally
                {
                    connection.Close();
                }
            }

        }
        public static void SaveAccount(Account account)
        {
            using var connection = new SQLiteConnection(ConnectionString(passDBPath));
            {
                if (account is not null)
                {
                    try
                    {
                        connection.Open();
                        string query;
                        bool newAccount = false;
                        if (AccountExists(account.Username))
                        {
                            query = "UPDATE passwords SET Hash = @Hash, Salt = @Salt, Email = @Email, AccountID = @AccountID, Admin = @Admin WHERE Username = @Username";
                        }
                        else
                        {
                            query = "INSERT INTO passwords VALUES (@Username, @Hash, @Salt, @Email, @AccountID, @Admin)";
                            newAccount = true;
                        }
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", account.Username);
                        command.Parameters.AddWithValue("@Hash", account.Hash);
                        command.Parameters.AddWithValue("@Salt", account.Salt);
                        command.Parameters.AddWithValue("@Email", account.Email);
                        command.Parameters.AddWithValue("@AccountID", account.ID);
                        command.Parameters.AddWithValue("@Admin", account.StoreAdmin);
                        command.ExecuteNonQuery();
                        if (newAccount) MessageBox.Show("Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Account information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

        }
        public static Account LoadAccount(string username)
        {
            Account account = null;
            if (AccountExists(username))
            {
                using var connection = new SQLiteConnection(ConnectionString(passDBPath));
                {
                    connection.Open();
                    var command = new SQLiteCommand($"SELECT * FROM passwords WHERE LOWER(Username) == LOWER(@Username)", connection);
                    command.Parameters.AddWithValue("@Username", username);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        account = new Account(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetBoolean(5));
                    }
                    connection.Close();
                }
            }
            return account;
        }

        //Library Data
        public static void SaveLibrary(int penaltyRate, int borrowLength, int maxRenewals, string lastOverdueCheck, int nextStudentID, int nextStaffID, int nextItemID, string borrowValues)
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                try
                {
                    string query;
                    connection.Open();
                    if (LibrarySaveExists())
                    {
                        query = "UPDATE Library SET PenaltyRate = @PenaltyRate, BorrowLength = @BorrowLength, MaxRenewals = @MaxRenewals, LastOverdueCheck = @LastOverdueCheck, NextStudentID = @NextStudentID, NextStaffID = @NextStaffID, NextItemID = @NextItemID, BorrowValues = @BorrowValues";
                    }
                    else
                    {
                        query = "INSERT INTO Library VALUES (@PenaltyRate, @BorrowLength, @MaxRenewals, @LastOverdueCheck, @NextStudentID, @NextStaffID, @NextItemID, @BorrowValues)";
                    }
                    
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@PenaltyRate", penaltyRate);
                    command.Parameters.AddWithValue("@BorrowLength", borrowLength);
                    command.Parameters.AddWithValue("@MaxRenewals", maxRenewals);
                    command.Parameters.AddWithValue("@LastOverdueCheck", lastOverdueCheck);
                    command.Parameters.AddWithValue("@NextStudentID", nextStudentID);
                    command.Parameters.AddWithValue("@NextStaffID", nextStaffID);
                    command.Parameters.AddWithValue("@NextItemID", nextItemID);
                    command.Parameters.AddWithValue("@BorrowValues", borrowValues);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void SaveIDs(int student, int staff, int mediaItem)
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                try
                {
                    connection.Open();
                    string query;
                    if (LibrarySaveExists())
                    {
                        query = "UPDATE Library SET NextStudentID = @NextStudentID, NextStaffID = @NextStaffID, NextItemID = @NextItemID";
                    }
                    else
                    {
                        return;
                    }
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@NextStudentID", student);
                    command.Parameters.AddWithValue("@NextStaffID", staff);
                    command.Parameters.AddWithValue("@NextItemID", mediaItem);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static (int penaltyRate, int borrowLength, int maxRenewals, string lastOverdueCheck, int studentNextID, int staffNextID, int itemNextID, string borrowValues) LoadLibrary()
        {
            int penaltyRate = 0;
            int borrowLength = 0;
            int maxRenewals = 0;
            string lastOverdueCheck = "";
            int studentNextID = 1;
            int staffNextID = -1;
            int itemNextID = 1;
            string borrowValues = "";

            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                try
                {
                    connection.Open();
                    string query = "Select * FROM Library";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        penaltyRate = reader.GetInt32(0);
                        borrowLength = reader.GetInt32(1);
                        maxRenewals = reader.GetInt32(2);
                        lastOverdueCheck = reader.GetString(3);
                        studentNextID = reader.GetInt32(4);
                        staffNextID = reader.GetInt32(5);
                        itemNextID = reader.GetInt32(6);
                        borrowValues = reader.GetString(7);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
                return (penaltyRate, borrowLength, maxRenewals, lastOverdueCheck, studentNextID, staffNextID, itemNextID, borrowValues);
            }
        }

        public static bool LibrarySaveExists()
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                try
                {
                    connection.Open();
                    string existsQuery = "SELECT EXISTS (SELECT 1 FROM Library)";
                    SQLiteCommand exists = new SQLiteCommand(existsQuery, connection);
                    return Convert.ToBoolean(exists.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    ErrorHandler error = new();
                    error.Add($"Something went wrong checking the database. This error should not occur. Caused by: \n{ex.Message}", "Error Checking if Libsave Exists");
                    error.Display();
                }
                finally
                {
                    connection.Close();
                }
                return false;
            }
        }

        //User Data
        public static void SaveUser(int id, int borrowCount, string firstName, string lastName, string feesOwed, string username)
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                try
                {
                    connection.Open();
                    string query;
                    bool newAccount = false;
                    if (UserExists(id))
                    {
                        query = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, FeesOwed = @FeesOwed, BorrowCount = @BorrowCount, Username = @Username WHERE ID = @ID";
                    }
                    else
                    {
                        query = "INSERT INTO Users VALUES (@ID, @FirstName, @LastName, @FeesOwed, @BorrowCount, @Username)";
                        newAccount = true;
                    }
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@BorrowCount", borrowCount);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@FeesOwed", feesOwed);
                    command.Parameters.AddWithValue("@Username", username);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void LoadUsers()
        {
                using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
                {
                    connection.Open();
                    var command = new SQLiteCommand($"SELECT * FROM Users", connection);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Library.ImportUser(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5));
                    }
                    connection.Close();
                }
        }
        public static bool UserExists(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                try
                {
                    connection.Open();
                    string existsQuery = "SELECT EXISTS (SELECT 1 FROM Users WHERE ID = @ID)";
                    SQLiteCommand exists = new SQLiteCommand(existsQuery, connection);
                    exists.Parameters.AddWithValue("@ID", id);
                    return Convert.ToBoolean(exists.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    ErrorHandler error = new();
                    error.Add($"Something went wrong checking the database. This error should not occur. Caused by: \n{ex.Message}", "Error Checking if User Exists");
                    error.Display();
                    throw new Exception("Account Check Exception - Data can not be verified, unsafe to continue");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //MediaInfoData
        public static bool MediaInfoExists(string isbn)
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                try
                {
                    connection.Open();
                    string existsQuery = "SELECT EXISTS (SELECT 1 FROM MediaInfo WHERE ISBN = @ISBN)";
                    SQLiteCommand exists = new SQLiteCommand(existsQuery, connection);
                    exists.Parameters.AddWithValue("@ISBN", isbn);
                    return Convert.ToBoolean(exists.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    ErrorHandler error = new();
                    error.Add($"Something went wrong checking the database. This error should not occur. Caused by: \n{ex.Message}", "Error Checking if MediaInfo Exists");
                    error.Display();
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }

        public static void SaveMediaInfo(string isbn, string authors, string title, string description)
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                try
                {
                    connection.Open();
                    string query;
                    bool newAccount = false;
                    if (MediaInfoExists(isbn))
                    {
                        query = "UPDATE MediaInfo SET Authors = @Authors, Title = @Title, Description = @Description WHERE ISBN = @ISBN";
                    }
                    else
                    {
                        query = "INSERT INTO MediaInfo VALUES (@ISBN, @Authors, @Title, @Description)";
                        newAccount = true;
                    }
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@ISBN", isbn);
                    command.Parameters.AddWithValue("@Authors", authors);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void LoadMediaInfo()
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                connection.Open();
                var command = new SQLiteCommand($"SELECT * FROM MediaInfo", connection);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Library.ImportMediaInfo(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                connection.Close();
            }
        }

        //MediaItemData
        public static bool MediaItemExists(int id)
        {

            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                try
                {
                    connection.Open();
                    string existsQuery = "SELECT EXISTS (SELECT 1 FROM MediaItem WHERE ID = @ID)";
                    SQLiteCommand exists = new SQLiteCommand(existsQuery, connection);
                    exists.Parameters.AddWithValue("@ID", id);
                    return Convert.ToBoolean(exists.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    ErrorHandler error = new();
                    error.Add($"Something went wrong checking the database. This error should not occur. Caused by: \n{ex.Message}", "Error Checking if MediaItem Exists");
                    error.Display();
                }
                finally
                {
                    connection.Close();
                }
            }
            return false;
        }
       
        public static void SaveMediaItem(int id, int IsDigital, string isbn, string initialCheckOutDate, string returnDate, int borrowerID)
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                try
                {
                    connection.Open();
                    string query;
                    bool newAccount = false;
                    if (MediaItemExists(id))
                    {
                        query = "UPDATE MediaItem SET IsDigital = @IsDigital, ISBN = @ISBN, InitialCheckOutDate = @InitialCheckOutDate, ReturnDate = @ReturnDate, BorrowerID = @BorrowerID WHERE ID = @ID";
                    }
                    else
                    {
                        query = "INSERT INTO MediaItem VALUES (@ID, @IsDigital, @ISBN, @InitialCheckOutDate, @ReturnDate, @BorrowerID)";
                        newAccount = true;
                    }
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@IsDigital", IsDigital);
                    command.Parameters.AddWithValue("@ISBN", isbn);
                    command.Parameters.AddWithValue("@InitialCheckOutDate", initialCheckOutDate);
                    command.Parameters.AddWithValue("@ReturnDate", returnDate);
                    command.Parameters.AddWithValue("@BorrowerID", borrowerID);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void LoadMediaItems()
        {
            using var connection = new SQLiteConnection(ConnectionString(mainDBPath));
            {
                connection.Open();
                var command = new SQLiteCommand($"SELECT * FROM MediaItem", connection);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Library.ImportMediaItem(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5));
                }
                connection.Close();
            }
        }
    }
}

