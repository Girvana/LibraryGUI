namespace LibraryGUI
{
    partial class MainForm
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
            LibrarySystemLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            addBooks_btn = new Button();
            IssueBooks_btn = new Button();
            profile_btn = new Button();
            library_btn = new Button();
            greet_label = new Label();
            panel3 = new Panel();
            view_profile = new Profile();
            view_library = new LibraryView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 82, 21);
            panel1.Controls.Add(LibrarySystemLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1283, 40);
            panel1.TabIndex = 0;
            // 
            // LibrarySystemLabel
            // 
            LibrarySystemLabel.AutoSize = true;
            LibrarySystemLabel.BorderStyle = BorderStyle.FixedSingle;
            LibrarySystemLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LibrarySystemLabel.ForeColor = Color.Ivory;
            LibrarySystemLabel.Location = new Point(5, 10);
            LibrarySystemLabel.Margin = new Padding(4, 0, 4, 0);
            LibrarySystemLabel.Name = "LibrarySystemLabel";
            LibrarySystemLabel.Size = new Size(199, 21);
            LibrarySystemLabel.TabIndex = 3;
            LibrarySystemLabel.Text = "Library System | Main Hub";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1253, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(14, 14);
            label1.TabIndex = 2;
            label1.Text = "X";
            label1.Click += label1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 82, 21);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(addBooks_btn);
            panel2.Controls.Add(IssueBooks_btn);
            panel2.Controls.Add(profile_btn);
            panel2.Controls.Add(library_btn);
            panel2.Controls.Add(greet_label);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1027, 40);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 652);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // logout_btn
            // 
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            logout_btn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.ForeColor = Color.Ivory;
            logout_btn.Location = new Point(36, 574);
            logout_btn.Margin = new Padding(4, 3, 4, 3);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(194, 52);
            logout_btn.TabIndex = 5;
            logout_btn.Text = "LOG OUT";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click_1;
            // 
            // addBooks_btn
            // 
            addBooks_btn.Cursor = Cursors.Hand;
            addBooks_btn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            addBooks_btn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            addBooks_btn.FlatStyle = FlatStyle.Flat;
            addBooks_btn.ForeColor = Color.Ivory;
            addBooks_btn.Location = new Point(15, 445);
            addBooks_btn.Margin = new Padding(4, 3, 4, 3);
            addBooks_btn.Name = "addBooks_btn";
            addBooks_btn.Size = new Size(233, 59);
            addBooks_btn.TabIndex = 4;
            addBooks_btn.Text = "ADD BOOKS";
            addBooks_btn.UseVisualStyleBackColor = true;
            addBooks_btn.Visible = false;
            addBooks_btn.Click += addBooks_btn_Click;
            // 
            // IssueBooks_btn
            // 
            IssueBooks_btn.Cursor = Cursors.Hand;
            IssueBooks_btn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            IssueBooks_btn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            IssueBooks_btn.FlatStyle = FlatStyle.Flat;
            IssueBooks_btn.ForeColor = Color.Ivory;
            IssueBooks_btn.Location = new Point(15, 354);
            IssueBooks_btn.Margin = new Padding(4, 3, 4, 3);
            IssueBooks_btn.Name = "IssueBooks_btn";
            IssueBooks_btn.Size = new Size(233, 59);
            IssueBooks_btn.TabIndex = 3;
            IssueBooks_btn.Text = "!!! UNUSED BUTTON !!!";
            IssueBooks_btn.UseVisualStyleBackColor = true;
            IssueBooks_btn.Visible = false;
            IssueBooks_btn.Click += IssueBooks_btn_Click;
            // 
            // profile_btn
            // 
            profile_btn.Cursor = Cursors.Hand;
            profile_btn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            profile_btn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            profile_btn.FlatStyle = FlatStyle.Flat;
            profile_btn.ForeColor = Color.Ivory;
            profile_btn.Location = new Point(15, 263);
            profile_btn.Margin = new Padding(4, 3, 4, 3);
            profile_btn.Name = "profile_btn";
            profile_btn.Size = new Size(233, 59);
            profile_btn.TabIndex = 2;
            profile_btn.Text = "PROFILE";
            profile_btn.UseVisualStyleBackColor = true;
            profile_btn.Click += profile_btn_Click;
            // 
            // library_btn
            // 
            library_btn.Cursor = Cursors.Hand;
            library_btn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            library_btn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            library_btn.FlatStyle = FlatStyle.Flat;
            library_btn.ForeColor = Color.Ivory;
            library_btn.Location = new Point(15, 168);
            library_btn.Margin = new Padding(4, 3, 4, 3);
            library_btn.Name = "library_btn";
            library_btn.Size = new Size(233, 59);
            library_btn.TabIndex = 1;
            library_btn.Text = "LIBRARY";
            library_btn.UseVisualStyleBackColor = true;
            library_btn.Click += Library_btn_Click;
            // 
            // greet_label
            // 
            greet_label.AutoSize = true;
            greet_label.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greet_label.ForeColor = Color.Ivory;
            greet_label.Location = new Point(36, 93);
            greet_label.Margin = new Padding(4, 0, 4, 0);
            greet_label.Name = "greet_label";
            greet_label.Size = new Size(158, 23);
            greet_label.TabIndex = 0;
            greet_label.Text = "Welcome, [USER]";
            // 
            // panel3
            // 
            panel3.Controls.Add(view_profile);
            panel3.Controls.Add(view_library);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 40);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1027, 652);
            panel3.TabIndex = 2;
            // 
            // view_profile
            // 
            view_profile.Location = new Point(0, 0);
            view_profile.Margin = new Padding(4, 3, 4, 3);
            view_profile.Name = "view_profile";
            view_profile.Size = new Size(1027, 652);
            view_profile.TabIndex = 4;
            // 
            // view_library
            // 
            view_library.Location = new Point(0, 0);
            view_library.Margin = new Padding(4, 3, 4, 3);
            view_library.Name = "view_library";
            view_library.Size = new Size(1027, 652);
            view_library.TabIndex = 0;
            view_library.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 692);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LibrarySystemLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button library_btn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Button IssueBooks_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addBooks_btn;
        private LibraryView issuedBooks1;
        private ReturnBooks returnBooks1;
        private ProfileEdit dashboard1;
        private LibraryView view_library;
        private Profile view_profile;
    }
}