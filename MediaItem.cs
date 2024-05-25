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
        public enum MediaTypes { Book, Article, Digital, Other }
        private MediaTypes mediaType;
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
            get => mediaType.ToString();
        }
        public int MediaInt
        {
            get => (int)mediaType;
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
        public MediaItem(MediaInfo mediaInfo)
        {
            id = NextID;
            NextID++;
            details = mediaInfo;
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
        public override string ToString()
        {
            var values = new StringBuilder();
            values.Append(id.ToString() + "█");
            values.Append(MediaInt+"█");
            if (initialCheckOutDate != DateTime.MaxValue) { values.Append(initialCheckOutDate.ToString() + "█"); }
            else { values.Append("Not Checked Out" + "█"); }
            if (returnDate != DateTime.MaxValue) { values.Append(returnDate.ToString() + "█"); }
            else { values.Append("Not Checked Out" + "█"); }
            values.Append(details.ID);
            return values.ToString();
        }
    }
}
