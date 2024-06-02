namespace LibraryGUI
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
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
            dashboard1.Visible = false;
            //   addBooks1.Visible = true;
            returnBooks1.Visible = false;
            issuedBooks1.Visible = false;
        }

        private void IssueBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            //   addBooks1.Visible = false;
            returnBooks1.Visible = false;
            issuedBooks1.Visible = true;
        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Library_btn_Click(object sender, EventArgs e)
        {
            if (CheckForNewAccount())
            {
                MessageBox.Show("Please save User info first", "Operation Forbidden");
                return;
            }
            view_library.Visible = true;
            view_profile.Visible = false;
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            view_library.Visible = false;
            view_profile.Visible = true;
        }

    }
}

