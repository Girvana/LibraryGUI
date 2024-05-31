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
        public static string CheckUsername(string username, bool verbose = true)
        {
            try
            {
                string regex = @"^[A-Za-z\d]+$";
                Regex re = new Regex(regex);
                if (!re.IsMatch(username))
                {
                    throw new Exception("Username must contain only English letters and numbers");
                }
                if (username.Length < 6)
                {
                    throw new Exception("Username must be at least 6 characters");
                }
                if (username.Length > 24)
                {
                    throw new Exception("Username must be at most 24 characters");
                }
                return username;
            }
            catch (Exception e)
            {
                if (verbose) MessageBox.Show(e.Message, "Invalid Username");
                return "";
            }
        }
        public static string CheckPassword(string password, bool verbose = true)
        {
            try
            {
                string regex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]+$";
                Regex re = new Regex(regex);
                if (!re.IsMatch(password))
                {
                    throw new Exception("Password must have at least one letter, one number, and one special character (@$!%*#?&)");
                }
                if (password.Length < 8)
                {
                    throw new Exception("Username must be at least 8 characters");
                }
                if (password.Length > 32)
                {
                    throw new Exception("Password must be at most 32 characters");
                }
                return password;
            }
            catch (Exception e)
            {
                if (verbose) MessageBox.Show(e.Message, "Invalid Password");
                return "";
            }
        }
        public static string CheckEmail(string email, bool verbose = true)
        {
            try
            {
                string regex = @"^[^.@\s][^@\s]+[^.@\s]@[^.@\s]+\.[^.@\s]+$";
                Regex re = new Regex(regex);
                if (!re.IsMatch(email))
                {
                    throw new Exception("Email address is not in a recognized format.");
                }
                if (email.Length > 254)
                {
                    throw new Exception("Email too long!");
                }
                return email;
            }
            catch (Exception e)
            {
                if (verbose) MessageBox.Show(e.Message, "Invalid Email Address");
                return "";
            }
        }

        //Handler
        public static void Login(string username, string password)
        {
            if (!DatabaseHandler.AccountExists(username))
            {
                MessageBox.Show("Account not found");
            }
            else
            {
                var account = DatabaseHandler.LoadAccount(username);
                if (account.Hash == HashPass(account.SaltBytes, password))
                {
                    activeAccount = account;
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
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
        public static void AssociateAccount(int ID)
        {
            if(Library.Users.ContainsKey(ID))
            {
                activeAccount.ID = ID;
                Library.Users[ID].Username = activeAccount.Username;
            }
        }


    }
}
