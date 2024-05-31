using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryGUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_email.Text == "" || register_username.Text == "" || register_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = AccountHandler.CheckUsername(register_username.Text, Program.errorHandler);
                string password = AccountHandler.CheckPassword(register_password.Text, Program.errorHandler);
                string email = AccountHandler.CheckEmail(register_email.Text, Program.errorHandler);
                if (username != "" && password != "")
                {
                    var newAccount = AccountHandler.CreateAccount(username, password, email);
                    if (newAccount is not null)
                    {
                        DatabaseHandler.SaveAccount(newAccount);
                    }
                    Program.errorHandler.Display();
                }
            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void register_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key
            {
                register_password.Focus();
                e.Handled = true;
            }
        }

        private void register_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key
            {
                register_email.Focus();
                e.Handled = true;
            }
        }

        private void register_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key
            {
                register_btn_Click(register_btn, null);
                e.Handled = true;
            }
        }
    }

}
                    
