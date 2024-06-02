namespace LibraryGUI
{
    partial class ProfileEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txt_lastname = new TextBox();
            isAdmin = new Button();
            textBox7 = new TextBox();
            label7 = new Label();
            txt_feesOwed = new TextBox();
            label6 = new Label();
            btn_save = new Button();
            btn_cancel = new Button();
            txt_email = new TextBox();
            label4 = new Label();
            txt_firstname = new TextBox();
            label1 = new Label();
            txt_username = new TextBox();
            label3 = new Label();
            addfromisbn_label = new Label();
            panel3 = new Panel();
            txt_borrowed = new TextBox();
            label9 = new Label();
            btn_return = new Button();
            lbx_borrowed = new ListBox();
            label14 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_lastname);
            panel1.Controls.Add(isAdmin);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_feesOwed);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_cancel);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_firstname);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addfromisbn_label);
            panel1.Location = new Point(23, 21);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 592);
            panel1.TabIndex = 0;
            // 
            // txt_lastname
            // 
            txt_lastname.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_lastname.Location = new Point(285, 161);
            txt_lastname.Margin = new Padding(4, 3, 4, 3);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(164, 22);
            txt_lastname.TabIndex = 46;
            // 
            // isAdmin
            // 
            isAdmin.BackColor = Color.FromArgb(50, 82, 21);
            isAdmin.CausesValidation = false;
            isAdmin.FlatAppearance.BorderSize = 0;
            isAdmin.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            isAdmin.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            isAdmin.FlatStyle = FlatStyle.Flat;
            isAdmin.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isAdmin.ForeColor = Color.Ivory;
            isAdmin.Location = new Point(-1, -1);
            isAdmin.Margin = new Padding(4, 3, 4, 3);
            isAdmin.Name = "isAdmin";
            isAdmin.Size = new Size(476, 38);
            isAdmin.TabIndex = 45;
            isAdmin.TabStop = false;
            isAdmin.Text = "ADMIN";
            isAdmin.UseVisualStyleBackColor = false;
            isAdmin.Visible = false;
            isAdmin.Click += isAdmin_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ButtonHighlight;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(214, 434);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(235, 15);
            textBox7.TabIndex = 43;
            textBox7.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(37, 376);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 16);
            label7.TabIndex = 42;
            label7.Text = "Fees Owed:";
            // 
            // txt_feesOwed
            // 
            txt_feesOwed.BackColor = SystemColors.ButtonHighlight;
            txt_feesOwed.BorderStyle = BorderStyle.None;
            txt_feesOwed.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_feesOwed.Location = new Point(122, 373);
            txt_feesOwed.Margin = new Padding(4, 3, 4, 3);
            txt_feesOwed.Name = "txt_feesOwed";
            txt_feesOwed.ReadOnly = true;
            txt_feesOwed.Size = new Size(326, 15);
            txt_feesOwed.TabIndex = 41;
            txt_feesOwed.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 437);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 16);
            label6.TabIndex = 40;
            label6.Text = "Borrows used for this period:";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(50, 82, 21);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_save.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.Ivory;
            btn_save.Location = new Point(285, 532);
            btn_save.Margin = new Padding(4, 3, 4, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(117, 38);
            btn_save.TabIndex = 37;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(50, 82, 21);
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_cancel.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.Ivory;
            btn_cancel.Location = new Point(69, 532);
            btn_cancel.Margin = new Padding(4, 3, 4, 3);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(117, 38);
            btn_cancel.TabIndex = 31;
            btn_cancel.Text = "CANCEL";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(122, 220);
            txt_email.Margin = new Padding(4, 3, 4, 3);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(326, 22);
            txt_email.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 223);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 35;
            label4.Text = "Email:";
            // 
            // txt_firstname
            // 
            txt_firstname.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_firstname.Location = new Point(122, 161);
            txt_firstname.Margin = new Padding(4, 3, 4, 3);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(164, 22);
            txt_firstname.TabIndex = 32;
            txt_firstname.TextChanged += txt_firstname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 167);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 16);
            label1.TabIndex = 31;
            label1.Text = "Name:";
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.ButtonHighlight;
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(122, 109);
            txt_username.Margin = new Padding(4, 3, 4, 3);
            txt_username.Name = "txt_username";
            txt_username.ReadOnly = true;
            txt_username.Size = new Size(326, 15);
            txt_username.TabIndex = 30;
            txt_username.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 29;
            label3.Text = "Username:";
            // 
            // addfromisbn_label
            // 
            addfromisbn_label.AutoSize = true;
            addfromisbn_label.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addfromisbn_label.Location = new Point(37, 53);
            addfromisbn_label.Margin = new Padding(4, 0, 4, 0);
            addfromisbn_label.Name = "addfromisbn_label";
            addfromisbn_label.Size = new Size(61, 23);
            addfromisbn_label.TabIndex = 28;
            addfromisbn_label.Text = "Profile";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txt_borrowed);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btn_return);
            panel3.Controls.Add(lbx_borrowed);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(519, 21);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(476, 592);
            panel3.TabIndex = 38;
            // 
            // txt_borrowed
            // 
            txt_borrowed.BackColor = SystemColors.ButtonHighlight;
            txt_borrowed.BorderStyle = BorderStyle.None;
            txt_borrowed.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_borrowed.Location = new Point(203, 480);
            txt_borrowed.Margin = new Padding(4, 3, 4, 3);
            txt_borrowed.Name = "txt_borrowed";
            txt_borrowed.ReadOnly = true;
            txt_borrowed.Size = new Size(231, 15);
            txt_borrowed.TabIndex = 47;
            txt_borrowed.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 483);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 16);
            label9.TabIndex = 46;
            label9.Text = "Currently Borrowed:";
            // 
            // btn_return
            // 
            btn_return.BackColor = Color.FromArgb(50, 82, 21);
            btn_return.FlatAppearance.BorderSize = 0;
            btn_return.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_return.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btn_return.FlatStyle = FlatStyle.Flat;
            btn_return.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_return.ForeColor = Color.Ivory;
            btn_return.Location = new Point(318, 532);
            btn_return.Margin = new Padding(4, 3, 4, 3);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(117, 38);
            btn_return.TabIndex = 30;
            btn_return.Text = "RETURN MEDIA";
            btn_return.UseVisualStyleBackColor = false;
            btn_return.Click += btn_return_Click;
            // 
            // lbx_borrowed
            // 
            lbx_borrowed.FormattingEnabled = true;
            lbx_borrowed.ItemHeight = 15;
            lbx_borrowed.Location = new Point(42, 92);
            lbx_borrowed.Margin = new Padding(4, 3, 4, 3);
            lbx_borrowed.Name = "lbx_borrowed";
            lbx_borrowed.Size = new Size(392, 364);
            lbx_borrowed.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(37, 38);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(144, 23);
            label14.TabIndex = 28;
            label14.Text = "Borrowed Books";
            // 
            // ProfileEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProfileEdit";
            Size = new Size(1027, 652);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label addfromisbn_label;
        private TextBox txt_email;
        private Label label4;
        private TextBox txt_firstname;
        private Label label1;
        private TextBox txt_username;
        private Label label3;
        private Panel panel3;
        private ListBox lbx_borrowed;
        private Label label14;
        private Button btn_save;
        private Button btn_cancel;
        private Button btn_return;
        private TextBox textBox7;
        private Label label7;
        private TextBox txt_feesOwed;
        private Label label6;
        private Button isAdmin;
        private TextBox txt_borrowed;
        private Label label9;
        private TextBox txt_lastname;
    }
}
