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
        public MediaInfo Details
        { 
            get => details;
        }
        public string MediaType
        {
            get
            {
                if (isDigital) return "Digital ";
                else return           "Physical";
            }
        }
        public int IsDigital
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
        public string TitleInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(GetTitle());
                if (sb.Length > 35)
                {
                    sb.Length = 32;
                    sb.Append("...");
                }
                return sb.ToString().PadRight(35)+ " | " +Info;
            }
        }
        public string Info
        {
            get
            {
                return $"{MediaType}  [{ID.ToString("00000")}]";
            }
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
            MessageBox.Show($"{GetTitle()} Renewed for {days} days, Now due back on {ReturnDate}","Media Renewed");
        }
        public void Return()
        {
            initialCheckOutDate = DateTime.MaxValue;
            returnDate = DateTime.MaxValue;
        }
    }
}
