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
        public static void CreatePassDB()
        {
            using var connection = new SQLiteConnection(ConnectionString(passDBPath));
            {
                SQLiteConnection.CreateFile(passDBPath);
                connection.Open();
                string tableString = "Create Table passwords(Username varchar(24) UNIQUE NOT NULL, Hash varchar(44) NOT NULL, Salt varchar(44) NOT NULL, Email varchar(254) NOT NULL, AccountID int NOT NULL)";
                var command = new SQLiteCommand(tableString, connection);
                command.ExecuteNonQuery();
                connection.Close();
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
                CreatePassDB();
            }
        }

        //Account Data
        public static bool AccountExists(string username)
        {
            using var connection = new SQLiteConnection(ConnectionString(passDBPath));
            {
                try
                {
                    connection.Open();
                    string existsQuery = "SELECT EXISTS (SELECT 1 FROM passwords WHERE Username = @Username)";
                    SQLiteCommand exists = new SQLiteCommand(existsQuery, connection);
                    exists.Parameters.AddWithValue("@Username", username);
                    return Convert.ToBoolean(exists.ExecuteScalar());
                }
                catch(Exception ex)
                {
                    throw new Exception("Error Checking if Account Exists");
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
                            query = "UPDATE passwords SET Hash = @Hash, Salt = @Salt, Email = @Email, AccountID = @AccountID WHERE Username = @Username";
                        }
                        else
                        {
                            query = "INSERT INTO passwords VALUES (@Username, @Hash, @Salt, @Email, @AccountID)";
                            newAccount = true;
                        }
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", account.Username);
                        command.Parameters.AddWithValue("@Hash", account.Hash);
                        command.Parameters.AddWithValue("@Salt", account.Salt);
                        command.Parameters.AddWithValue("@Email", account.Email);
                        command.Parameters.AddWithValue("@AccountID", account.ID);
                        command.ExecuteNonQuery();
                        if (newAccount) MessageBox.Show("Registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    var command = new SQLiteCommand($"SELECT * FROM passwords WHERE username=\"{username}\"", connection);
                    using var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        account = new Account(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                    }
                    connection.Close();
                }
            }
            return account;
        }
    }
}

