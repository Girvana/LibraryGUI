using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryGUI
{
    internal class MediaInfo
    {
        //## Fields ##
        public enum MediaTypes { Book, Article, Digital, Other }
        private int id;
        private MediaTypes mediaType;
        private string author;
        private string title;
        private string description;

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
        public string Author
        {
            get => author;
        }
        public string Title
        {
            get => title;
        }
        public string Description
        {
            get => description;
            set => description = string.Concat(value.Split('█')); //removes any instance of '█' delimeter character from blurb
        }
        //## Constructors ##
        public MediaInfo(int id)
        {
        }
        //## Methods ##
        public string ToString()
        {
            return $"{ID}█{MediaInt}█{Author}█{Title}█{Description}";
        }
    }

}
