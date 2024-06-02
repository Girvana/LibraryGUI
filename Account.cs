using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI
{
    internal class Account
    {
        private string username;
        private string passwordhash;
        private string salt;
        private int accountID;
        private string email;
        bool isAdmin;
        public string Username
        {
            get => username;
        }
        public string Name
        {
            get
            {
                if (Library.Users.ContainsKey(accountID))
                {
                    if (Library.Users[accountID] != null)
                    {
                        return (Library.Users[accountID].Name);
                    }
                }
                return username;
            }
        }
        public string Hash
        {
            get => passwordhash;
        }
        public string Salt
        {
            get => salt;
        }
        public byte[] SaltBytes
        {
            get
            {
                return Convert.FromBase64String(salt);
            }
        }
        public int ID
        {
            get => accountID;
            internal set => accountID = value;
        }
        public string Email
        {
            get => email; 
            set => email = value;
        }
        public bool IsAdmin
        {
            get => isAdmin;
            internal set => isAdmin = value;
        }
        internal int StoreAdmin
        {
            get
            {
                if (isAdmin) return 1; else return 0;
            }
        }
        public Account(string username, string passwordhash, string salt, string email, int id = 0, bool isAdmin = false)
        {

            this.username = username;
            this.passwordhash = passwordhash;
            this.salt = salt;
            this.accountID = id;
            this.email = email;
            this.isAdmin = isAdmin;
        }

    }
}
