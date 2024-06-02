using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI
{
    internal class Library
    {
        //## Fields ##

        private static int penaltyRate = 5;
        private static int borrowLength = 14; //length of a borrow period in days
        private static int maxRenewals = 1;
        private static Dictionary<int, User> users = new Dictionary<int, User>();
        private static Dictionary<int, MediaItem> mediaItems = new Dictionary<int, MediaItem>();
        private static Dictionary<string, MediaInfo> mediaInfo = new Dictionary<string, MediaInfo>();
        private static Dictionary<int, int> borrowedItems = new Dictionary<int, int>();
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
        public static int BorrowLength
        {
            get => borrowLength;
        }
        public static Dictionary<string, MediaInfo> MediaInfo
        {
            get => mediaInfo;
        }
        //## Constructors ##
        public Library()
        { 
        }

        //## Methods ##

        //Media Management
        public static void AddMedia(string isbn, bool isDigital)
        {
            if (!mediaInfo.ContainsKey(isbn))
            {
                mediaInfo.Add(isbn, new MediaInfo(isbn));
            }
            var newMedia = new MediaItem(mediaInfo[isbn], isDigital);
            mediaItems.Add(newMedia.ID, newMedia);
        }
        public static void AddMediaInfo(MediaInfo info)
        {
            if (!mediaInfo.ContainsKey(info.ISBN))
            {
                mediaInfo.Add(info.ISBN, info);
            }
            else
            {
                Program.errorHandler.Add("ISBN already in use", "Problem Adding Media");
            }
        }
        public static void RemoveMedia(int mediaID)
        {
            if (mediaItems.ContainsKey(mediaID))
            {
                var borrower = GetBorrower(mediaID);
                borrower.Return(mediaID);
                mediaItems.Remove(mediaID);
            }
            else
            {
                Program.errorHandler.Add("Media ID not recognized, media could not be removed", "Problem Removing Media");
            }
        }

        //User Management
        public static void AddUser(User user)
        {
            if (users.ContainsKey(user.ID))
            {
                Program.errorHandler.Add("User ID already exists, user could not be added", "Problem Adding User");
            }
            else
            {
                users.Add(user.ID, user);
            }
        }

        //Borrowing
        public static void TryBorrow(int mediaID, int userID)
        {
            if(!ValidateMediaID(mediaID) && !ValidateUserID(userID) && !MediaIsAvailable(mediaID))
            {
                DoBorrow(mediaID, userID);
            }
            return;
        }
        public static void DoBorrow(int mediaID, int userID)
        {
            var borrower = users[userID];
            var media = mediaItems[mediaID];
            if (media.CanBeBorrowed() && borrower.CanBorrow())
            {
                borrower.Borrow(mediaID);
                media.CheckOut(borrowLength);
                borrowedItems.Add(mediaID, userID);
            }
            else
            {
                Program.errorHandler.Add("User unable to borrow this media at this time.", "Problem Borrowing Media");
            }
        }
        public static void Return(int mediaID)
        {
            if (borrowedItems.ContainsKey(mediaID))
            {
                var borrower = GetBorrower(mediaID);
                var media = mediaItems[mediaID];
                borrower.Return(mediaID);
                media.Return();
                borrowedItems.Remove(mediaID);
            }
            else
            {
                Program.errorHandler.Add("Media not in borrowed list, media could not be returned", "Problem Returning Media");
            }
        }
        public static void Renew(int mediaID)
        {
            var media = GetMedia(mediaID);
            if (media.CanBeRenewed(maxRenewals)) media.Renew(borrowLength);
        }

        //Validation
        public static bool ValidateMediaID(int mediaID)
        {
            if (!mediaItems.ContainsKey(mediaID))
            {
                Program.errorHandler.Add("Media ID not recognized, media could not be borrowed", "Problem Borrowing Media");
                return false;
            }
            return true;
        }
        public static bool ValidateUserID(int userID)
        {
            if (!users.ContainsKey(userID))
            {
                Program.errorHandler.Add("User ID not recognized, media could not be borrowed", "Problem Borrowing Media");
                return false;
            }
            return true;
        }
        public static bool MediaIsAvailable(int mediaID)
        {
            if (borrowedItems.ContainsKey(mediaID))
            {
                Program.errorHandler.Add($"Media Item {mediaID} Unavailable. \n({mediaItems[mediaID].GetTitle()} - {mediaItems[mediaID].GetAuthors()}", "Media Unavailable");
                return false;
            }
            return true;
        }

        //Information
        public static User GetBorrower(int mediaID)
        {
            if (borrowedItems.ContainsKey(mediaID))
            {
                return users[borrowedItems[mediaID]];
            }
            else return null;
        }
        public static MediaItem GetMedia(int mediaID)
        {
            if (mediaItems.ContainsKey(mediaID))
            {
                return mediaItems[mediaID];
            }
            else return null;
        }
        public static bool ContainsMediaInfo(string isbn)
        {
            if (mediaInfo.ContainsKey(isbn)) return true;
            else return false;
        }
        public static List<MediaItem> GetItemsFromISBN(string isbn)
        {
            var list = mediaItems.Values.Where(i => i.Details.ISBN == isbn).ToList();
            return list;
        }
    }
}
