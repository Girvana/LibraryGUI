using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI
{
    internal class Library
    {
        //## Fields ##

        private int penaltyRate = 5;
        private Dictionary<int, Student> students = new Dictionary<int, Student>();
        private Dictionary<int, Staff> staff = new Dictionary<int, Staff>();
        private Dictionary<int, MediaItem> media = new Dictionary<int, MediaItem>();
        private Dictionary<int, MediaInfo> cachedInfo = new Dictionary<int, MediaInfo>();
        private Dictionary<MediaItem, Account> borrowedItems = new Dictionary<MediaItem, Account>();
        private DateTime lastOverdueCheck = DateTime.Today;
        //## Properties ##
        internal Dictionary<int, Student> StudentDict //Used for storage access
        {
            get => students;
            set => students = value;
        }
        internal Dictionary<int, Staff> StaffDict //Used for storage access
        {
            get => staff;
            set => staff = value;
        }
        internal int PenaltyRate //Used for storage access
        {
            get => penaltyRate;
            set => penaltyRate = value;
        }
        internal DateTime LastOverdueCheck //Used for storage access
        {
            get => lastOverdueCheck;
            set => lastOverdueCheck = value;
        }
        //## Constructors ##
        public Library()
        {
        }
    }
}
