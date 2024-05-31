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

        private static int penaltyRate = 5;
        private static Dictionary<int, User> users = new Dictionary<int, User>();
        private static Dictionary<int, MediaItem> media = new Dictionary<int, MediaItem>();
        private static Dictionary<int, MediaInfo> cachedInfo = new Dictionary<int, MediaInfo>();
        private static Dictionary<MediaItem, User> borrowedItems = new Dictionary<MediaItem, User>();
        private static DateTime lastOverdueCheck = DateTime.Today;
        //## Properties ##
        internal static Dictionary<int, User> Users //Used for storage access
        { 
            get => users; 
            set => users = value;
        }
        internal static Dictionary<int, User> StudentDict
        {
            get
            {
               return new Dictionary<int, User>(users.Where(x => x.Key > 0));
            }
        }
        internal static Dictionary<int, User> StaffDict
        {
            get
            {
                return new Dictionary<int, User>(users.Where(x => x.Key < 0));
            }
        }
        internal static int PenaltyRate //Used for storage access
        {
            get => penaltyRate;
            set => penaltyRate = value;
        }
        internal static DateTime LastOverdueCheck //Used for storage access
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
