namespace LibraryGUI
{
    public partial class MainForm : Form
    {
        string currentPage = "";

        public MainForm()
        {
            InitializeComponent();
            HideViews();
            UpdateInfo();
            view_profile.Visible = true;
        }
        private void HideViews()
        {
            view_addBooks.Visible = false;
            view_library.Visible = false;
            view_profile.Visible = false;
        }
        private void UpdateInfo()
        {
            LibrarySystemLabel.Text = $"Library System | {currentPage}";
            greet_label.Text = $"Welcome {AccountHandler.ActiveAccount.Name}";
            if (AccountHandler.ActiveAccount.IsAdmin) addBooks_btn.Visible = true;
            else addBooks_btn.Visible = false;
        }

        private bool CheckForNewAccount()
        {
            return AccountHandler.ActiveAccount.ID == 0;
        }

        private void addBooks_btn_Click(object sender, EventArgs e)
        {
            if (CheckForNewAccount())
            {
                MessageBox.Show("Please save User info first", "Operation Forbidden");
                return;
            }
            HideViews();
            view_addBooks.Visible = true;
            currentPage = "Add Media";
            UpdateInfo();
        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                AccountHandler.LogOut();
                lForm.Show();
                this.Close();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Library_btn_Click(object sender, EventArgs e)
        {
            if (CheckForNewAccount())
            {
                MessageBox.Show("Please save User info first", "Operation Forbidden");
                return;
            }
            HideViews();
            view_library.LoadData(this, null);
            view_library.Visible = true;
            currentPage = "Library";
            UpdateInfo();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            if (CheckForNewAccount())
            {
                MessageBox.Show("Please save User info first", "Operation Forbidden");
                return;
            }
            HideViews();
            view_profile.Visible = true;
            currentPage = "Profile";
            UpdateInfo();
        }

    }
}

