using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        string lastISBN = "";
        public LibraryView()
        {
            InitializeComponent();
            search_datagridview.Columns.Add("title", "Title");
            search_datagridview.Columns.Add("authors", "Authors");
            LoadAllData();
        }


        public void LoadAllData()
        {
            search_datagridview.Rows.Clear();
            foreach (var item in Library.SearchMediaInfo(""))
            {
                int index = search_datagridview.Rows.Count;
                search_datagridview.Rows.Add(item.Title, item.Authors);
                search_datagridview.Rows[index].Tag = item.ISBN;
            }
        }
        public void LoadSearchData()
        {
            string searchTerm = search_txtbox.Text;
            search_datagridview.Rows.Clear();
            foreach (var item in Library.SearchMediaInfo(searchTerm))
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
                    lastISBN = isbn;
                    UpdateListBox(isbn);
                }
            }
        }
        private void UpdateListBox(string isbn)
        {
            availaible_listbx.Items.Clear();
            availaible_listbx.DisplayMember = "Info";
            foreach (MediaItem item in Library.GetItemsFromISBN(isbn))
            {
                availaible_listbx.Items.Add(item);
            }
            if (availaible_listbx.Items.Count == 0)
            {
                availaible_listbx.Items.Add("No Copies Available");
            }
        }

        private void borrow_btn_Click(object sender, EventArgs e)
        {
            if (availaible_listbx.SelectedIndex >= 0 && (availaible_listbx.SelectedItem != "No Copies Available"))
            {
                MediaItem a = availaible_listbx.SelectedItem as MediaItem;
                Library.TryBorrow(a.ID, AccountHandler.ActiveAccount.ID);
                UpdateListBox(lastISBN);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            LoadSearchData();
        }
    }
}
