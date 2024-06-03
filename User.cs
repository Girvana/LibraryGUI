using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI
{
    internal class User
    {
        //## Fields ##
        protected static int maxSimultaneousBorrows = int.MaxValue;   //modified by subclasses
        protected static int maxBorrows = int.MaxValue;               //modified by subclasses
        protected int borrowCount = 0;
        protected int id;
        protected string firstName = "";
        protected string lastName = "";
        protected decimal feesOwed = 0;
        protected List<int> borrowedMedia = new List<int>();
        protected string username = "";


        //## Properties ##
        public int ID
        {
            get => id;
        }
        public string Name
        {
            get => firstName + " " + lastName;
        }
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        public decimal FeesOwed
        {
            get => feesOwed;
            internal set => feesOwed = value;
        }
        public List<MediaItem> BorrowedMediaList
        {
            get
            {
                List<MediaItem> list = new List<MediaItem>();
                foreach (int ID in borrowedMedia)
                {
                    list.Add(Library.GetMedia(ID));
                }
                return list;
            }
        }
        public string Username
        {
            get => username;
            set => username = value;
        }
        public string BorrowCount
        {
            get => borrowCount.ToString();
        }
        public virtual string BorrowMax
        {
            get
            {
                if (maxBorrows != int.MaxValue)
                    return maxBorrows.ToString();
                else return "No Maximum Borrows";
            }
        }
        public virtual string BorrowMaxSimultaneous
        {
            get
            {
                if (maxSimultaneousBorrows != int.MaxValue)
                    return maxSimultaneousBorrows.ToString();
                else return "No Maximum";
            }
        }
        //## Constructors ##
        public User()
        {

        }
        public User(string firstName, string lastName) // Person class should only be used for initial library account, Staff or Student should be used for other instances
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        internal User(int id, string firstName, string lastName, int feesOwed, int borrowCount, string username)//To be used for Storage Loading
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.feesOwed = feesOwed;
            this.username = username;
            this.borrowCount = borrowCount;
        }

        //## Methods ##
        public void Return(int MediaID)
        {
            if (borrowedMedia.Contains(ID))
            {
                borrowedMedia.Remove(ID);
            }
        }

        public virtual bool CanBorrow()
        {
            if (borrowCount < maxBorrows && borrowedMedia.Count < maxSimultaneousBorrows)
            {
                return true;
            }
            return false;
        }

        public virtual void Borrow(int mediaID, bool fromLoad = false)
        {
            if (!fromLoad) borrowCount++;
            borrowedMedia.Add(mediaID);
        }

        public void ExportForDatabase()
        {
            DatabaseHandler.SaveUser(id, borrowCount, firstName, lastName, feesOwed.ToString(), username);
        }

    }
}
