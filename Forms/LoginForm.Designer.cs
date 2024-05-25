namespace LibraryGUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            exitButton = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            loginBtn = new Button();
            signupBtn = new Button();
            login_showPass = new CheckBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 82, 21);
            panel1.Controls.Add(exitButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 40);
            panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.AutoSize = true;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(343, 10);
            exitButton.Margin = new Padding(4, 0, 4, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(14, 14);
            exitButton.TabIndex = 1;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(146, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 1;
            label2.Text = "LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 166);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // login_username
            // 
            login_username.Location = new Point(14, 190);
            login_username.Margin = new Padding(4, 3, 4, 3);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(327, 34);
            login_username.TabIndex = 3;
            login_username.TextChanged += textBox1_TextChanged;
            // 
            // login_password
            // 
            login_password.Location = new Point(14, 276);
            login_password.Margin = new Padding(4, 3, 4, 3);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(327, 34);
            login_password.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 252);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 18);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(50, 82, 21);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            loginBtn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.Snow;
            loginBtn.Location = new Point(18, 428);
            loginBtn.Margin = new Padding(4, 3, 4, 3);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(328, 46);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.FromArgb(50, 82, 21);
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.FlatAppearance.BorderSize = 0;
            signupBtn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            signupBtn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            signupBtn.FlatStyle = FlatStyle.Flat;
            signupBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupBtn.ForeColor = Color.Snow;
            signupBtn.Location = new Point(18, 526);
            signupBtn.Margin = new Padding(4, 3, 4, 3);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(328, 46);
            signupBtn.TabIndex = 7;
            signupBtn.Text = "REGISTER";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += button2_Click;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(209, 317);
            login_showPass.Margin = new Padding(4, 3, 4, 3);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(117, 20);
            login_showPass.TabIndex = 8;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 606);
            Controls.Add(login_showPass);
            Controls.Add(signupBtn);
            Controls.Add(loginBtn);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.CheckBox login_showPass;
        private Label label1;
    }
}