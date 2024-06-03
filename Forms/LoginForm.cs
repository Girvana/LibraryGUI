using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm rform = new RegisterForm();
            rform.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = AccountHandler.CheckUsername(login_username.Text, Program.errorHandler);
                string password = AccountHandler.CheckPassword(login_password.Text, Program.errorHandler);
                if (username != "" && password != "")
                {
                    AccountHandler.Login(username, password);
                }
                Program.errorHandler.Display();

                if (AccountHandler.ActiveAccount is not null)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    this.Hide();
                }
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            Program.CloseApplication();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
        private void login_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key
            {
                login_password.Focus();
                e.Handled = true;
            }
        }

        private void login_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key
            {
                loginBtn_Click(loginBtn, null);
                e.Handled = true;
            }
        }
    }
}

