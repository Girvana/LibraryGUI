using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryGUI
{
    
    internal class AccountHandler
    {
        //###### NOTICE ##############################################################################################################
        // Account handling in this app provides no real security                                                                   #
        // the passwords database is accessible and could be swapped out for a dummy db                                             #
        // as well as openly containing all the information needed to create an identical account object                            #
        // the goal of this class is purely to allow for a login experience in the app while not storing passwords in plaintext     #
        //###########################################################################################################################

        //Default Credentials : [admin] AdminAccount, AdminP4$$
        //                      [user] TestUser1, P4$$word

        //## Fields ##
        private static Account activeAccount = null;
        private const int keySize = 256 / 8;
        private const int iterations = 300000;
        //## Properties ##
        public static Account ActiveAccount
            {
                get => activeAccount;
            }

        //## Methods ##

        //Crypto
        public static byte[] GenerateSalt()
        {
            var salt = RandomNumberGenerator.GetBytes(keySize);
            return salt;
        }
        public static string HashPass(byte[] salt, string password)
        {

            var key = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, HashAlgorithmName.SHA512, keySize);
            return Convert.ToBase64String(key);
        }

        //String Validation
        public static string CheckUsername(string username, ErrorHandler handler)
        {
                string regex = @"^[A-Za-z\d]+$";
                Regex re = new Regex(regex);
                bool isValid = true;
                if (!re.IsMatch(username))
                {
                    handler.Message("Username must contain only English letters and numbers");
                    isValid = false;
                }
                if (username.Length < 6)
                {
                    handler.Message("Username must be at least 6 characters");
                    isValid = false;
                }
                if (username.Length > 24)
                {
                    handler.Message("Username must be at most 24 characters");
                    isValid = false;
                }
                if (!isValid)
                {
                    handler.Title("Invalid Username");
                    return "";
                }
                else return username;
        }
        public static string CheckPassword(string password, ErrorHandler handler)
        {

            string regex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]+$";
            Regex re = new Regex(regex);
            bool isValid = true;
            if (!re.IsMatch(password))
            {
                handler.Message("Password must have at least one letter, one number, and one special character (@$!%*#?&)");
                isValid = false;
            }
            if (password.Length < 8)
            {
                handler.Message("Username must be at least 8 characters");
                isValid = false;
            }
            if (password.Length > 32)
            {
                handler.Message("Password must be at most 32 characters");
                isValid = false;
            }
            if (!isValid)
            {
                handler.Title("Invalid Password");
                return "";
            }
            else return password;
        }
        public static string CheckEmail(string email, ErrorHandler handler)
        {
            string regex = @"^[^.@\s][^@\s]+[^.@\s]@[^.@\s]+\.[^.@\s]+$";
            Regex re = new Regex(regex);
            bool isValid = true;
            if (!re.IsMatch(email))
            {
                handler.Message("Email address is not in a recognized format.");
                isValid = false;
            }
            if (email.Length > 254)
            {
                handler.Message("Email too long!");
                isValid = false;
            }
            if (!isValid)
            {
                handler.Title("Invalid Email");
                return "";
            }
            else return email;
        }

        //Handler
        public static bool Login(string username, string password, bool admin = false)
        {
            if (!DatabaseHandler.AccountExists(username))
            {
                MessageBox.Show("Account not found", "Login Failed", MessageBoxButtons.OK);
            }
            else
            {
                var account = DatabaseHandler.LoadAccount(username);
                if (account.Hash == HashPass(account.SaltBytes, password))
                {
                    if (admin && account.IsAdmin)
                    {
                        activeAccount.IsAdmin = true;
                        DatabaseHandler.SaveAccount(activeAccount);
                        return true;
                    }
                    else activeAccount = account;
                }
                else
                {
                    MessageBox.Show("Incorrect Password", "Login Failed", MessageBoxButtons.OK);
                }
            }
            return false;
        }
        public static void LogOut()
        {
            activeAccount = null;
        }
        public static Account CreateAccount(string username, string password, string email)
        {
            if (DatabaseHandler.AccountExists(username))
            {
                MessageBox.Show($"{username} already exists!");
                return null;
            }
            var salt = GenerateSalt();
            var hash = HashPass(salt, password);
            var account =  new Account(username, hash, Convert.ToBase64String(salt), email);
            activeAccount = account;
            return account;
        }
        public static void AccociateUserWithAccount(int ID)
        {
            if(ID == 0)
            {
                activeAccount.ID = 0;
                return;
            }
            if(Library.Users.ContainsKey(ID))
            {
                activeAccount.ID = ID;
                Library.Users[ID].Username = activeAccount.Username;
                DatabaseHandler.SaveAccount(activeAccount);
                Library.Users[ID].ExportForDatabase();
            }
            else
            {
                MessageBox.Show("Account Association Failed", "Error"); //Debug message, not meant to be error handled, shouldn't be possible to hit
            }
        }
        public static void SetAdmin()
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

    }
}
