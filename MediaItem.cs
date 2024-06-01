using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LibraryGUI
{
    internal class MediaItem
    {
        //## Fields ##
        private static int NextID = 1;
        private int id;
        private bool isDigital;
        private MediaInfo details;
        private DateTime initialCheckOutDate = DateTime.MaxValue;   //maxvalue used to represent unborrowed media state
        private DateTime returnDate = DateTime.MaxValue;            //maxvalue used to represent unborrowed media state

        //## Properties ##
        public int ID
        {
            get => id;
        }
        public string MediaType
        {
            get
            {
                if (isDigital) return "Digital";
                else return "Physical";
            }
        }
        public int MediaInt
        {
            get
            {
                if (isDigital) return 1;
                else return 0;
            }
        }
        public DateTime InitialCheckOutDate
        {
            get => initialCheckOutDate;
            private set => initialCheckOutDate = value;
        }
        public DateTime ReturnDate
        {
            get => returnDate;
            private set => returnDate = value;
        }
        //## Constructors ##
        public MediaItem(MediaInfo mediaInfo, bool isDigital)
        {
            id = NextID;
            NextID++;
            details = mediaInfo;
            this.isDigital = isDigital;
        }
        //## Methods ##

        /// <summary>
        /// <c>ForceNextID</c> should NOT be called by anything other than the storage manager.
        /// </summary>
        internal static void ForceNextID(int id)
        {
            NextID = id;
        }
        public string[] ToArray()
        {
            var values = new List<string>();
            values.Add(id.ToString());
            values.Add($"{MediaInt}");
            if (initialCheckOutDate != DateTime.MaxValue) { values.Add(initialCheckOutDate.ToString()); }
            else { values.Add("Not Checked Out"); }
            if (returnDate != DateTime.MaxValue) { values.Add(returnDate.ToString()); }
            else { values.Add("Not Checked Out"); }
            values.Add(details.ID.ToString());
            return values.ToArray();
        }

        public string GetTitle()
        {
            return details.Title;
        }
        public string GetAuthors()
        {
            return details.Authors;
        }

        public bool CanBeBorrowed()
        {
            if (returnDate != DateTime.MaxValue || initialCheckOutDate != DateTime.MaxValue)
            {
                return false;
            }
            return true;

        }
        public void CheckOut(int days)
        {
                initialCheckOutDate = DateTime.Today;
                returnDate = DateTime.Today.AddDays(days);
        }
        public bool CanBeRenewed(int maxRenewals = 1)
        {
            if (initialCheckOutDate.AddDays(Library.BorrowLength * maxRenewals) < DateTime.Today)
            {
                return true;
            }
            return false;
        }
        public void Renew(int days)
        {
            returnDate.AddDays(days);
        }
        public void Return()
        {
            initialCheckOutDate = DateTime.MaxValue;
            returnDate = DateTime.MaxValue;
        }
    }
}
