namespace LibraryGUI
{
    partial class RegisterForm
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
            register_showPass = new CheckBox();
            signIn_btn = new Button();
            register_btn = new Button();
            register_password = new TextBox();
            label4 = new Label();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            exitButton = new Label();
            register_email = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showPass.Location = new Point(209, 317);
            register_showPass.Margin = new Padding(4, 3, 4, 3);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(117, 20);
            register_showPass.TabIndex = 3;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // signIn_btn
            // 
            signIn_btn.BackColor = Color.FromArgb(50, 82, 21);
            signIn_btn.Cursor = Cursors.Hand;
            signIn_btn.FlatAppearance.BorderSize = 0;
            signIn_btn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            signIn_btn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            signIn_btn.FlatStyle = FlatStyle.Flat;
            signIn_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signIn_btn.ForeColor = Color.Snow;
            signIn_btn.Location = new Point(18, 526);
            signIn_btn.Margin = new Padding(4, 3, 4, 3);
            signIn_btn.Name = "signIn_btn";
            signIn_btn.Size = new Size(328, 46);
            signIn_btn.TabIndex = 6;
            signIn_btn.Text = "LOGIN";
            signIn_btn.UseVisualStyleBackColor = false;
            signIn_btn.Click += signIn_btn_Click;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(50, 82, 21);
            register_btn.Cursor = Cursors.Hand;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            register_btn.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.Snow;
            register_btn.Location = new Point(18, 428);
            register_btn.Margin = new Padding(4, 3, 4, 3);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(328, 46);
            register_btn.TabIndex = 5;
            register_btn.Text = "REGISTER";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_password
            // 
            register_password.Font = new Font("Segoe UI", 14.25F);
            register_password.Location = new Point(14, 276);
            register_password.Margin = new Padding(4, 3, 4, 3);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(327, 33);
            register_password.TabIndex = 2;
            register_password.KeyPress += register_password_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 252);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 18);
            label4.TabIndex = 13;
            label4.Text = "Password";
            // 
            // register_username
            // 
            register_username.Font = new Font("Segoe UI", 14.25F);
            register_username.Location = new Point(14, 190);
            register_username.Margin = new Padding(4, 3, 4, 3);
            register_username.Name = "register_username";
            register_username.Size = new Size(327, 33);
            register_username.TabIndex = 1;
            register_username.KeyPress += register_username_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 166);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 22);
            label2.TabIndex = 10;
            label2.Text = "REGISTRATION";
            label2.TextAlign = ContentAlignment.TopCenter;
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
            panel1.TabIndex = 9;
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
            exitButton.TabIndex = 7;
            exitButton.Text = "X";
            exitButton.Click += exitButton_Click;
            // 
            // register_email
            // 
            register_email.Font = new Font("Segoe UI", 14.25F);
            register_email.Location = new Point(14, 363);
            register_email.Margin = new Padding(4, 3, 4, 3);
            register_email.Name = "register_email";
            register_email.Size = new Size(327, 33);
            register_email.TabIndex = 4;
            register_email.KeyPress += register_email_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 339);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(41, 18);
            label5.TabIndex = 18;
            label5.Text = "Email";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 606);
            Controls.Add(register_email);
            Controls.Add(label5);
            Controls.Add(register_showPass);
            Controls.Add(signIn_btn);
            Controls.Add(register_btn);
            Controls.Add(register_password);
            Controls.Add(label4);
            Controls.Add(register_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox register_showPass;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.TextBox register_email;
        private System.Windows.Forms.Label label5;
    }
}