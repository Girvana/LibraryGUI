using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryGUI
{
    public partial class AddBooks : UserControl
    {
        public AddBooks()
        {
            InitializeComponent();
            lbx_auto.DisplayMember = "Title";
            lbx_auto.ValueMember = "ISBN";
            foreach(MediaInfo info in Library.MediaInfo.Values)
            {
                lbx_auto.Items.Add(info);
            }
        }



        private void btn_addAP_Click(object sender, EventArgs e)
        {
            string isbn = txt_ISBNAuto.Text;
            if (!Library.ContainsMediaInfo(isbn)) Library.AddMediaInfo(new MediaInfo(isbn));
            Library.AddMedia(isbn, false);
            if (!lbx_auto.Items.Contains(Library.MediaInfo[isbn])) lbx_auto.Items.Add(Library.MediaInfo[isbn]);
        }

        private void btn_addAD_Click(object sender, EventArgs e)
        {
            string isbn = txt_ISBNAuto.Text;
            if (!Library.ContainsMediaInfo(isbn)) Library.AddMediaInfo(new MediaInfo(isbn));
            Library.AddMedia(isbn, true);
            if (!lbx_auto.Items.Contains(Library.MediaInfo[isbn])) lbx_auto.Items.Add(Library.MediaInfo[isbn]);
        }

        private void btn_addMP_Click(object sender, EventArgs e)
        {
            string isbn = txt_ISBNManual.Text;
            string[] authors = txt_authors.Text.Split(',');
            string title = txt_title.Text;
            string description = txt_description.Text;
            var newMediaInfo = new MediaInfo(isbn, authors.ToList(), title, description);
            if (!Library.ContainsMediaInfo(isbn)) Library.AddMediaInfo(newMediaInfo);
            Library.AddMedia(isbn, false);
            if (!lbx_auto.Items.Contains(Library.MediaInfo[isbn])) lbx_auto.Items.Add(Library.MediaInfo[isbn]);
        }

        private void btn_addMD_Click(object sender, EventArgs e)
        {
            string isbn = txt_ISBNManual.Text;
            string[] authors = txt_authors.Text.Split(',');
            string title = txt_title.Text;
            string description = txt_description.Text;
            var newMediaInfo = new MediaInfo(isbn, authors.ToList(), title, description);
            if (!Library.ContainsMediaInfo(isbn)) Library.AddMediaInfo(newMediaInfo);
            Library.AddMedia(isbn, true);
            if (!lbx_auto.Items.Contains(Library.MediaInfo[isbn])) lbx_auto.Items.Add(Library.MediaInfo[isbn]);
        }

        private void lbx_auto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbx_auto.SelectedIndex != -1)
            {
                string selectedISBN = (lbx_auto.Items[lbx_auto.SelectedIndex] as MediaInfo).ISBN;
                txt_ISBNAuto.Text = selectedISBN;
            }

        }
    }
}
