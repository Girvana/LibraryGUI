using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI
{
    internal class Account
    {
        //## Fields ##
        protected int id;
        protected string name = "";
        protected int feesOwed = 0;
        protected List<MediaItem> borrowedMedia = new List<MediaItem>();

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
        public List<MediaItem> BorrowedMediaList
        {
            get => borrowedMedia;
        }
        public string[][] BorrowedMedia
        {
            get
            {
                var output = new List<string[]>();
                foreach (MediaItem media in borrowedMedia)
                {
                    output.Add(media.ToArray());
                }
                return output.ToArray();
            }
        }
        //## Constructors ##
        public Account()
        {

        }
        public Account(string name) // Person class should only be used for initial library account, Staff or Student should be used for other instances
        {
            this.name = name;
        }
        internal Account(int id, string name, int feesOwed)//To be used for Storage Loading
        {
            this.id = id;
            this.name = name;
            this.feesOwed = feesOwed;
        }
    }

    internal class Student : Account
    {
        //## Fields ##
        const int maxBorrows = 5;
        private int borrowCount = 0;
        private static int nextID = 1;
        //## Properties ##
        public static int NextID
        {
            get => nextID;
        }
        public int BorrowCount
        {
            get => borrowCount;
        }
        public int BorrowMax
        {
            get => maxBorrows;
        }
        //## Constructors ##
        public Student(string name) : base(name)
        {
            id = nextID++;
        }
        internal Student(int id, string name, int feesOwed, int borrowCount) : base(id, name, feesOwed)//To be used for Storage Loading
        {
            this.borrowCount = borrowCount;
        }
        //## Methods ##
    }

    internal class Staff : Account
    {
        //## Fields ##
        private static int nextID = -1;
        private bool isAdmin = false;
        //## Properties ##
        public static int NextID
        {
            get => nextID;
        }
        //## Constructors ##
        public Staff(string name, bool isAdmin = false) : base(name)
        {
            id = nextID--;
            this.isAdmin = isAdmin;
        }
        internal Staff(int id, string name, int feesOwed, bool isAdmin) : base(id, name, feesOwed)
        {
            this.isAdmin = isAdmin;
        } //To be used for Storage Loading
        internal static void OverrideID(int input) //Used for loading library state. should not be called otherwise.
        {
            nextID = input;
        }
    }
}
