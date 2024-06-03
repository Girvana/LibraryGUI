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
    public partial class Profile : UserControl
    {

        bool newAccount = true;
        Account account = new Account("", "", "", "", 0, false);
        public Profile()
        {
            InitializeComponent();
            if (AccountHandler.ActiveAccount is not null) // should always be true, did this way to stop VS Designer breaking
            {
                newAccount = AccountHandler.ActiveAccount.ID == 0;
                account = AccountHandler.ActiveAccount;
            }
            UpdateInfo();
            if (newAccount) StartEdit(true);
        }

        public void StartEdit(bool isNew = false)
        {
            txt_firstname_edit.Visible = true;
            txt_lastname_edit.Visible = true;
            txt_email_edit.Visible = true;
            txt_email_edit.Text = account.Email;
            txt_email.Visible = false;
            txt_name.Visible = false;
            btn_edit.Visible = false;
            setAdmin.Visible = true;
            if (account.IsAdmin)
            {
                setAdmin.Text = "Revoke Admin";
            }
            else
            {
                setAdmin.Text = "Make Admin";
            }
            if (!isNew)
            {
                txt_firstname_edit.Text = Library.Users[account.ID].FirstName;
                txt_lastname_edit.Text = Library.Users[account.ID].LastName;
                btn_cancel.Visible = true;
                btn_save.Visible = true;
            }
            else
            {
                btn_createStaff.Visible = true;
                btn_CreateStudent.Visible = true;
            }
        }

        public void StopEdit()
        {
            setAdmin.Visible = false;
            txt_firstname_edit.Visible = false;
            txt_lastname_edit.Visible = false;
            txt_email_edit.Visible = false;
            txt_email.Visible = true;
            txt_name.Visible = true;
            btn_edit.Visible = true;
            btn_cancel.Visible = false;
            btn_save.Visible = false;
            btn_CreateStudent.Visible = false;
            btn_createStaff.Visible = false;
            if (account.IsAdmin) isAdmin.Visible = true;
            else isAdmin.Visible = false;
            UpdateInfo();
        }

        internal void UpdateInfo()
        {
            if (AccountHandler.ActiveAccount is not null) // should always be true, did this way to stop VS Designer breaking
            {
                newAccount = AccountHandler.ActiveAccount.ID == 0;
                account = AccountHandler.ActiveAccount;
            }
            if (account.IsAdmin) setAdmin.Text = "Revoke Admin";
            else setAdmin.Text = "Make Admin";
            txt_username.Text = account.Username;
            txt_email.Text = account.Email;
            if (!newAccount)
            {
                if (!Library.Users.ContainsKey(account.ID)) //User Data can not be loaded
                {
                    AccountHandler.AccociateUserWithAccount(0);
                    UpdateInfo(); //calls function again with new account = true because ID = 0
                    return; //prevent first call finishing
                }
                var user = Library.Users[account.ID];
                txt_firstname_edit.Text = user.FirstName;
                txt_lastname_edit.Text = user.LastName;
                txt_borrowsUsed.Text = $"{user.BorrowCount} / {user.BorrowMax}";
                txt_borrowed.Text = $"{user.BorrowedMediaList.Count.ToString()} / {user.BorrowMaxSimultaneous}";
                txt_feesOwed.Text = string.Format("{0:C2}", user.FeesOwed);
                txt_name.Text = user.Name;
                lbx_borrowed.DataSource = user.BorrowedMediaList;
                lbx_borrowed.DisplayMember = "TitleInfo";
                lbx_borrowed.Refresh();
            }
        }

        public void btn_edit_Click(object sender, EventArgs e)
        {
            StartEdit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var user = Library.Users[account.ID];
            user.FirstName = txt_firstname_edit.Text;
            user.LastName = txt_lastname_edit.Text;
            user.Username = account.Username;
            account.Email = txt_email.Text;
            StopEdit();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            StopEdit();
        }

        private void btn_createStaff_Click(object sender, EventArgs e)
        {
            var user = new Staff(txt_firstname_edit.Text, txt_lastname_edit.Text);
            Library.AddUser(user);
            AccountHandler.AccociateUserWithAccount(user.ID);
            newAccount = false;
            StopEdit();
        }

        private void btn_CreateStudent_Click(object sender, EventArgs e)
        {
            var user = new Student(txt_firstname_edit.Text, txt_lastname_edit.Text);
            Library.AddUser(user);
            AccountHandler.AccociateUserWithAccount(user.ID);
            newAccount = false;
            StopEdit();
        }

        private void setAdmin_Click(object sender, EventArgs e)
        {
            if (account.IsAdmin)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to remove admin rights from this account?", "Remove Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    account.IsAdmin = false;
                    DatabaseHandler.SaveAccount(account);
                }
            }
            else
            {
                AccountHandler.SetAdmin();
            }
            UpdateInfo();
        }



        private void return_btn_Click(object sender, EventArgs e)
        {
            if (lbx_borrowed.SelectedIndex >= 0)
            {
                MediaItem a = lbx_borrowed.SelectedItem as MediaItem;
                Library.Return(a.ID);
            }
            UpdateInfo();
        }


        private void btn_renew_Click(object sender, EventArgs e)
        {
            if (lbx_borrowed.SelectedIndex >= 0)
            {
                MediaItem a = lbx_borrowed.SelectedItem as MediaItem;
                Library.Renew(a.ID);
            }
            UpdateInfo();
        }
    }
}
