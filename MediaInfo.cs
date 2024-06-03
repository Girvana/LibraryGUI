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
        private string isbn;
        private List<string> authors;
        private string title;
        private string description;

        //## Properties ##
        public string ISBN
        {
            get => isbn;
        }
        public string Authors
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (string s in authors)
                {
                    sb.Append(s + ", ");
                }
                sb.Length -= 2;
                return sb.ToString();
            }
        }
        public string Title
        {
            get => title;
        }
        public string ExportAuthors
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (string s in authors)
                {
                    sb.Append(s + "|");
                }
                sb.Length -=1;
                return sb.ToString();
            }
        }
        public string Description
        {
            get => description;
            set => description = string.Concat(value.Split('█')); //removes any instance of '█' delimeter character from blurb
        }
        //## Constructors ##
        public MediaInfo(string isbn)
        {
            try
            {
                var info = GoogleBooksRetriever.GetInfoFromISBN(isbn);
                this.isbn = isbn;
                this.title = info.title;
                this.authors = info.authors;
                this.description = info.description;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        internal MediaInfo(string isbn, List<string> authors, string title, string description)//To be called by storage class.
        {
            this.isbn = isbn;
            this.title = title;
            this.authors = authors;
            this.description = description;
        }
        //## Methods ##
        public void ExportForDatabase()
        {

            DatabaseHandler.SaveMediaInfo(isbn, ExportAuthors, title, description);
        }
    }

}
