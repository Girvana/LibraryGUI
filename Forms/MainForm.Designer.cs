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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.returnBooks_btn = new System.Windows.Forms.Button();
            this.IssueBooks_btn = new System.Windows.Forms.Button();
            this.addBooks_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new LibraryGUI.Dashboard();
            this.addBooks1 = new LibraryGUI.AddBooks();
            this.returnBooks1 = new LibraryGUI.ReturnBooks();
            this.issuedBooks1 = new LibraryGUI.IssuedBooks();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Library System | Main Hub";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1074, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(21)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.returnBooks_btn);
            this.panel2.Controls.Add(this.IssueBooks_btn);
            this.panel2.Controls.Add(this.addBooks_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(880, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 565);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.Ivory;
            this.logout_btn.Location = new System.Drawing.Point(162, 507);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(45, 45);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "LOG OUT";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click_1);
            // 
            // returnBooks_btn
            // 
            this.returnBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.returnBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.returnBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_btn.ForeColor = System.Drawing.Color.Ivory;
            this.returnBooks_btn.Location = new System.Drawing.Point(13, 386);
            this.returnBooks_btn.Name = "returnBooks_btn";
            this.returnBooks_btn.Size = new System.Drawing.Size(200, 51);
            this.returnBooks_btn.TabIndex = 4;
            this.returnBooks_btn.Text = "RETURN BOOKS";
            this.returnBooks_btn.UseVisualStyleBackColor = true;
            this.returnBooks_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // IssueBooks_btn
            // 
            this.IssueBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.IssueBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.IssueBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueBooks_btn.ForeColor = System.Drawing.Color.Ivory;
            this.IssueBooks_btn.Location = new System.Drawing.Point(13, 307);
            this.IssueBooks_btn.Name = "IssueBooks_btn";
            this.IssueBooks_btn.Size = new System.Drawing.Size(200, 51);
            this.IssueBooks_btn.TabIndex = 3;
            this.IssueBooks_btn.Text = "ISSUE BOOKS";
            this.IssueBooks_btn.UseVisualStyleBackColor = true;
            this.IssueBooks_btn.Click += new System.EventHandler(this.IssueBooks_btn_Click);
            // 
            // addBooks_btn
            // 
            this.addBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.addBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.addBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_btn.ForeColor = System.Drawing.Color.Ivory;
            this.addBooks_btn.Location = new System.Drawing.Point(13, 228);
            this.addBooks_btn.Name = "addBooks_btn";
            this.addBooks_btn.Size = new System.Drawing.Size(200, 51);
            this.addBooks_btn.TabIndex = 2;
            this.addBooks_btn.Text = "ADD BOOKS";
            this.addBooks_btn.UseVisualStyleBackColor = true;
            this.addBooks_btn.Click += new System.EventHandler(this.addBooks_btn_Click_1);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.ForeColor = System.Drawing.Color.Ivory;
            this.dashboard_btn.Location = new System.Drawing.Point(13, 146);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(200, 51);
            this.dashboard_btn.TabIndex = 1;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click_1);
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_label.ForeColor = System.Drawing.Color.Ivory;
            this.greet_label.Location = new System.Drawing.Point(31, 81);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(151, 23);
            this.greet_label.TabIndex = 0;
            this.greet_label.Text = "Welcome, Admin";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.issuedBooks1);
            this.panel3.Controls.Add(this.returnBooks1);
            this.panel3.Controls.Add(this.addBooks1);
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 565);
            this.panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, -1);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(880, 565);
            this.dashboard1.TabIndex = 0;
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(0, -1);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(880, 565);
            this.addBooks1.TabIndex = 1;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(0, -1);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(880, 565);
            this.returnBooks1.TabIndex = 2;
            // 
            // issuedBooks1
            // 
            this.issuedBooks1.Location = new System.Drawing.Point(0, -1);
            this.issuedBooks1.Name = "issuedBooks1";
            this.issuedBooks1.Size = new System.Drawing.Size(880, 565);
            this.issuedBooks1.TabIndex = 3;
            this.issuedBooks1.Load += new System.EventHandler(this.issuedBooks1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.Button addBooks_btn;
        private System.Windows.Forms.Button IssueBooks_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button returnBooks_btn;
        private IssuedBooks issuedBooks1;
        private ReturnBooks returnBooks1;
        private AddBooks addBooks1;
        private Dashboard dashboard1;
    }
}