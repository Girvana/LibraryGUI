using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryGUI
{
    public partial class LibraryView : UserControl
    {
        public LibraryView()
        {
            InitializeComponent();
            search_datagridview.Columns.Add("title", "Title");
            search_datagridview.Columns.Add("authors", "Authors");
            LoadData(this, null);
        }


        public void LoadData(object sender, EventArgs e)
        {
            search_datagridview.Rows.Clear();
            foreach (var item in Library.MediaInfo.Values)
            {
                int index = search_datagridview.Rows.Count;
                search_datagridview.Rows.Add(item.Title, item.Authors);
                search_datagridview.Rows[index].Tag = item.ISBN;
            }
        }

        private void search_datagridview_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                string isbn = search_datagridview.Rows[index].Tag as string;
                if (isbn != null)
                {
                    var mediaInfo = Library.MediaInfo[isbn];
                    author_txtbox.Text = mediaInfo.Authors;
                    title_txtbox.Text = mediaInfo.Title;
                    description_txtbox.Text = mediaInfo.Description;
                    availaible_listbx.Items.Clear();
                    availaible_listbx.DisplayMember = "Info";
                    foreach(MediaItem item in Library.GetItemsFromISBN(isbn)) 
                    {
                        availaible_listbx.Items.Add(item);
                    }
                }
            }
        }
    }
}
