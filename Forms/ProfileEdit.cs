using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryGUI
{
    public partial class ProfileEdit : UserControl
    {
        bool newAccount = AccountHandler.ActiveAccount.ID == 0;
        public ProfileEdit()
        {
            InitializeComponent();
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            var account = AccountHandler.ActiveAccount;
            if (account.IsAdmin) isAdmin.Text = "Revoke Admin";
            else isAdmin.Text = "Make Admin";
            txt_username.Text = account.Username;
            txt_email.Text = account.Email;
            if (!newAccount)
            {
                var user = Library.Users[account.ID];
                txt_firstname.Text = user.FirstName;
                txt_lastname.Text = user.LastName;
                txt_borrowed.Text = $"{user.BorrowCount} / {user.BorrowMax}";
                txt_feesOwed.Text = string.Format("{0:C2}", user.FeesOwed);
            }
            PopulateBorrowedBox();
        }

        private void PopulateBorrowedBox()
        {

        }
        private void isAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var account = AccountHandler.ActiveAccount;
            if (newAccount)
            {
                var user = new User(txt_firstname.Text, txt_lastname.Text);
                AccountHandler.AssociateAccount(user.ID);
            }
            else
            {
                var user = Library.Users[account.ID];
                user.FirstName = txt_firstname.Text;
                user.LastName = txt_lastname.Text;
            }
            account.Email = txt_email.Text;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
        private void btn_return_Click(object sender, EventArgs e)
        {

        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
