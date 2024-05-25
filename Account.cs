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
}
