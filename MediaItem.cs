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
        private static int nextMediaItemID = 1;
        private int id;
        private MediaInfo details;
        private DateTime initialCheckOutDate = DateTime.MaxValue;   //maxvalue used to represent unborrowed media state
        private DateTime returnDate = DateTime.MaxValue;            //maxvalue used to represent unborrowed media state

        //## Properties ##
        public int ID
        {
            get => id;
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
            id = nextMediaItemID;
            nextMediaItemID++;
            details = mediaInfo;
        }
        //## Methods ##
        public string[] ToArray()
        {
            var values = new List<string>();
            values.Add(id.ToString());
            if (initialCheckOutDate != DateTime.MaxValue) { values.Add(initialCheckOutDate.ToString()); }
            else { values.Add("Not Checked Out"); }
            if (returnDate != DateTime.MaxValue) { values.Add(returnDate.ToString()); }
            else { values.Add("Not Checked Out"); }
            string[] details = this.details.ToString().Split('█');
            for (int i = 0; i < details.Length; i++)
            {
                values.Add(details[i]);
            }
            return values.ToArray();
        }
        public string ToString()
        {
            var values = new StringBuilder();
            values.Append(id.ToString());
            if (initialCheckOutDate != DateTime.MaxValue) { values.Append(initialCheckOutDate.ToString()); }
            else { values.Append("Not Checked Out"); }
            if (returnDate != DateTime.MaxValue) { values.Append(returnDate.ToString()); }
            else { values.Append("Not Checked Out"); }
            string[] details = this.details.ToString().Split('█');
            for (int i = 0; i < details.Length; i++)
            {
                values.Append(details[i]);
            }
            return values.ToString();
        }
    }
}
