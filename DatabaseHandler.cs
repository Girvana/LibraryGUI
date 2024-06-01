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

namespace LibraryGUI
{
    internal class DatabaseHandler
    {
        //## Fields ##
        private static string resourcePath = Storage.basePath;
        //Password Database
        private static string passDBName = "passwd.db3";
        private static string passDBPath = Path.Combine(resourcePath, passDBName);
        
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
        public static void CreatePasswordTable(bool dropOld = false)
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
            CreatePasswordTable();
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
                catch(Exception ex)
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
    }
}

