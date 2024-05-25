﻿using System;
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
        private static int NextID;
        private int id;
        private string isbn;
        private List<string> authors;
        private string title;
        private string description;

        //## Properties ##
        public int ID
        {
            get => id;
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
                this.description = info.description;
                this.authors = info.authors;
                this.id = NextID;
                NextID++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //## Methods ##
        public override string ToString()
        {
            return $"{ID}█{Authors}█{Title}█{Description}";
        }

        /// <summary>
        /// <c>ForceNextID</c> should NOT be called by anything other than the storage manager.
        /// </summary>
        internal static void ForceNextID(int id) 
        {
            NextID = id;
        }
    }

}
