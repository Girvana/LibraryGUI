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
        static int maxSimultaneousBorrows = int.MaxValue;   //modified by subclasses
        static int maxBorrows = int.MaxValue;               //modified by subclasses
        protected int borrowCount = 0;
        protected int id;
        protected string name = "";
        protected int feesOwed = 0;
        protected List<int> borrowedMedia = new List<int>();
        protected string username = "";


        //## Properties ##
        public int ID
        {
            get => id;
        }
        public string Name
        {
            get => name;
        }
        public int FeesOwed
        {
            get => feesOwed;
            internal set => feesOwed = value;
        }
        public List<int> BorrowedMediaList
        {
            get => borrowedMedia;
        }
        public string Username
        {
            get => username;
            set => username = value;
        }
        //## Constructors ##
        public User()
        {

        }
        public User(string name) // Person class should only be used for initial library account, Staff or Student should be used for other instances
        {
            this.name = name;
        }
        internal User(int id, string name, int feesOwed)//To be used for Storage Loading
        {
            this.id = id;
            this.name = name;
            this.feesOwed = feesOwed;
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

        public virtual void Borrow(int mediaID)
        {
            borrowCount++;
            borrowedMedia.Add(mediaID);
        }
    }
}
