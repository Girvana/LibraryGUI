using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        private static Dictionary<int, int> borrowedItems = new Dictionary<int, int>(); //<mediaItem ID, user ID>
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
            newMedia.ExportForDatabase();
            mediaItems.Add(newMedia.ID, newMedia);
        }
        public static void AddMediaInfo(MediaInfo info)
        {
            if (!mediaInfo.ContainsKey(info.ISBN))
            {
                info.ExportForDatabase();
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
                user.ExportForDatabase();
                
                users.Add(user.ID, user);
            }
        }

        //Borrowing
        public static void TryBorrow(int mediaID, int userID)
        {
            if(ValidateMediaID(mediaID) && ValidateUserID(userID) && MediaIsAvailable(mediaID))
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
                media.ExportForDatabase(userID);
                borrowedItems.Add(mediaID, userID);
                MessageBox.Show($"Borrowed {GetMedia(mediaID).Details.Title}, ID:  {mediaID.ToString("00000")}", "Borrow Success");
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
        public static List<MediaInfo> SearchMediaInfo(string searchTerm)
        {
            var results = mediaInfo.Values.Where(i => (i.Title.Contains(searchTerm) || i.Authors.Contains(searchTerm))).ToList();
            return results;
        }
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
            var list = mediaItems.Values.Where(i => (i.Details.ISBN == isbn && MediaIsAvailable(i.ID))).ToList();
            return list;
        }

        //Storage
        public static void ExportForDatabase(bool fullExport = false)
        {
            string borrowValues = $"{Student.BorrowInfo[0]},{Student.BorrowInfo[1]},{Staff.BorrowInfo[0]},{Staff.BorrowInfo[1]}";
            DatabaseHandler.SaveLibrary(penaltyRate, borrowLength, maxRenewals, LastOverdueCheck.ToString("s"), Student.NextID, Staff.NextID, MediaItem.NextID, borrowValues);
            if (fullExport)
            {
                ExportUsers();
                ExportMediaItems();
                ExportMediaInfo();
            }
        }
        public static void ExportNextUserIDs()
        {
            DatabaseHandler.SaveIDs(Student.NextID, Staff.NextID, MediaItem.NextID);
        }

        public static void ExportUsers()
        {
            foreach (var user in users.Values) 
            {
                user.ExportForDatabase();
            }
        }
        public static void ExportMediaItems()
        {
            foreach (var mediaItem in mediaItems.Values)
            {
                int borrowerID = 0;
                if(borrowedItems.ContainsKey(mediaItem.ID))
                {
                    borrowerID = borrowedItems[mediaItem.ID];
                }
                mediaItem.ExportForDatabase(borrowerID);
            }
        }
        public static void ExportMediaInfo()
        {
            foreach (var mediaInfo in mediaInfo.Values)
            {
                mediaInfo.ExportForDatabase();
            }
        }
        public static void ImportFromDatabase()
        {
            if (DatabaseHandler.LibrarySaveExists())
            {
                var values = DatabaseHandler.LoadLibrary();
                penaltyRate = values.penaltyRate;
                borrowLength = values.borrowLength;
                maxRenewals = values.maxRenewals;
                lastOverdueCheck = DateTime.Parse(values.lastOverdueCheck);
                Student.ForceNextID(values.studentNextID);
                Staff.ForceNextID(values.staffNextID);
                MediaItem.ForceNextID(values.itemNextID);
                //BorrowValues is ugly but was running out of time to properly plan databases
                string[] borrowValues = values.borrowValues.Split(',');
                int[] set = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    set[i] = Int32.Parse(borrowValues[i]);
                }
                Student.SetBorrowValues(set[0], set[1]);
                Staff.SetBorrowValues(set[2], set[3]);
            }
            DatabaseHandler.LoadMediaInfo();
            DatabaseHandler.LoadUsers();
            DatabaseHandler.LoadMediaItems();

        }

        public static void ImportMediaItem(int id, int isDigital, string isbn, string initialCheckOutDate, string returnDate, int borrowerID)
        {
            if (!mediaItems.ContainsKey(id))
            {
                if (!mediaInfo.ContainsKey(isbn))
                {
                    var newInfo = new MediaInfo(isbn);
                    AddMediaInfo(newInfo);
                }
                var info = mediaInfo[isbn];
                var iDate = DateTime.Parse(initialCheckOutDate);
                var rDate = DateTime.Parse(returnDate);
                bool digital = isDigital == 1;
                var newItem = new MediaItem(id, digital, info, iDate, rDate);
                mediaItems.Add(newItem.ID, newItem);
                if(borrowerID != 0 && users.ContainsKey(borrowerID)) 
                {
                    borrowedItems.Add(id, borrowerID);
                    users[borrowerID].Borrow(id, true);
                }
            }
        }

        public static void ImportMediaInfo(string isbn, string authors, string title, string description)
        {
            if (!mediaInfo.ContainsKey(isbn))
            {
                var sb = new StringBuilder(authors);
                sb.Length -= 2;
                var authorList = sb.ToString().Split("|").ToList();
                mediaInfo.Add(isbn, new MediaInfo(isbn, authorList, title, description));
            }
        }

        public static void ImportUser(int id, string firstName, string lastName, int feesOwed, int borrowCount, string username)
        {
            User newUser = null;
            if (id < 0)
            {
                newUser = new Staff(id, firstName, lastName, feesOwed, borrowCount, username);
            }
            else if (id > 0)
            {
                newUser = new Student(id, firstName, lastName, feesOwed, borrowCount, username);
            }
            else return;
            if (users.ContainsKey(newUser.ID))
            {
                Program.errorHandler.Add("User ID already exists, user could not be added", "Problem Adding User");
            }
            else
            {
                users.Add(newUser.ID, newUser);
            }
        }
    }
}
