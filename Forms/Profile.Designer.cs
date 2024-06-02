namespace LibraryGUI
{
    partial class Profile
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
            borrow_btn = new Button();
            isAdmin = new Button();
            textBox7 = new TextBox();
            label7 = new Label();
            txt_feesOwed = new TextBox();
            label6 = new Label();
            txt_email = new TextBox();
            label4 = new Label();
            txt_borrowed = new TextBox();
            label9 = new Label();
            panel3 = new Panel();
            lbx_borrowed = new ListBox();
            label14 = new Label();
            txt_name = new TextBox();
            txt_username = new TextBox();
            label3 = new Label();
            addfromisbn_label = new Label();
            panel1 = new Panel();
            setAdmin = new Button();
            btn_createStaff = new Button();
            btn_CreateStudent = new Button();
            btn_save = new Button();
            btn_cancel = new Button();
            txt_lastname_edit = new TextBox();
            btn_edit = new Button();
            txt_email_edit = new TextBox();
            txt_firstname_edit = new TextBox();
            label1 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // borrow_btn
            // 
            borrow_btn.BackColor = Color.FromArgb(50, 82, 21);
            borrow_btn.FlatAppearance.BorderSize = 0;
            borrow_btn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            borrow_btn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            borrow_btn.FlatStyle = FlatStyle.Flat;
            borrow_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            borrow_btn.ForeColor = Color.Ivory;
            borrow_btn.Location = new Point(318, 532);
            borrow_btn.Margin = new Padding(4, 3, 4, 3);
            borrow_btn.Name = "borrow_btn";
            borrow_btn.Size = new Size(117, 38);
            borrow_btn.TabIndex = 30;
            borrow_btn.Text = "RETURN MEDIA";
            borrow_btn.UseVisualStyleBackColor = false;
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
            // txt_email
            // 
            txt_email.BackColor = SystemColors.ButtonHighlight;
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(122, 220);
            txt_email.Margin = new Padding(4, 3, 4, 3);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(326, 15);
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
            // txt_borrowed
            // 
            txt_borrowed.BackColor = SystemColors.ButtonHighlight;
            txt_borrowed.BorderStyle = BorderStyle.None;
            txt_borrowed.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_borrowed.Location = new Point(204, 483);
            txt_borrowed.Margin = new Padding(4, 3, 4, 3);
            txt_borrowed.Name = "txt_borrowed";
            txt_borrowed.ReadOnly = true;
            txt_borrowed.Size = new Size(231, 15);
            txt_borrowed.TabIndex = 47;
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
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txt_borrowed);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(borrow_btn);
            panel3.Controls.Add(lbx_borrowed);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(519, 21);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(476, 592);
            panel3.TabIndex = 40;
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
            // txt_name
            // 
            txt_name.BackColor = SystemColors.ButtonHighlight;
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(122, 161);
            txt_name.Margin = new Padding(4, 3, 4, 3);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(326, 15);
            txt_name.TabIndex = 32;
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.ButtonHighlight;
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(122, 109);
            txt_username.Margin = new Padding(4, 3, 4, 3);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(326, 15);
            txt_username.TabIndex = 30;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(setAdmin);
            panel1.Controls.Add(btn_createStaff);
            panel1.Controls.Add(btn_CreateStudent);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_cancel);
            panel1.Controls.Add(txt_lastname_edit);
            panel1.Controls.Add(btn_edit);
            panel1.Controls.Add(txt_email_edit);
            panel1.Controls.Add(isAdmin);
            panel1.Controls.Add(txt_firstname_edit);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_feesOwed);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addfromisbn_label);
            panel1.Location = new Point(23, 21);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 592);
            panel1.TabIndex = 39;
            // 
            // setAdmin
            // 
            setAdmin.BackColor = Color.FromArgb(50, 82, 21);
            setAdmin.CausesValidation = false;
            setAdmin.FlatAppearance.BorderSize = 0;
            setAdmin.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            setAdmin.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            setAdmin.FlatStyle = FlatStyle.Flat;
            setAdmin.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setAdmin.ForeColor = Color.Ivory;
            setAdmin.Location = new Point(-1, -1);
            setAdmin.Margin = new Padding(4, 3, 4, 3);
            setAdmin.Name = "setAdmin";
            setAdmin.Size = new Size(476, 38);
            setAdmin.TabIndex = 54;
            setAdmin.TabStop = false;
            setAdmin.Text = "setADMIN";
            setAdmin.UseVisualStyleBackColor = false;
            setAdmin.Visible = false;
            setAdmin.Click += this.setAdmin_Click;
            // 
            // btn_createStaff
            // 
            btn_createStaff.BackColor = Color.FromArgb(50, 82, 21);
            btn_createStaff.FlatAppearance.BorderSize = 0;
            btn_createStaff.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_createStaff.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btn_createStaff.FlatStyle = FlatStyle.Flat;
            btn_createStaff.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_createStaff.ForeColor = Color.Ivory;
            btn_createStaff.Location = new Point(244, 532);
            btn_createStaff.Margin = new Padding(4, 3, 4, 3);
            btn_createStaff.Name = "btn_createStaff";
            btn_createStaff.Size = new Size(177, 38);
            btn_createStaff.TabIndex = 53;
            btn_createStaff.Text = "SAVE (STAFF)";
            btn_createStaff.UseVisualStyleBackColor = false;
            btn_createStaff.Visible = false;
            btn_createStaff.Click += btn_createStaff_Click;
            // 
            // btn_CreateStudent
            // 
            btn_CreateStudent.BackColor = Color.FromArgb(50, 82, 21);
            btn_CreateStudent.FlatAppearance.BorderSize = 0;
            btn_CreateStudent.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_CreateStudent.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btn_CreateStudent.FlatStyle = FlatStyle.Flat;
            btn_CreateStudent.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CreateStudent.ForeColor = Color.Ivory;
            btn_CreateStudent.Location = new Point(54, 532);
            btn_CreateStudent.Margin = new Padding(4, 3, 4, 3);
            btn_CreateStudent.Name = "btn_CreateStudent";
            btn_CreateStudent.Size = new Size(182, 38);
            btn_CreateStudent.TabIndex = 52;
            btn_CreateStudent.Text = "SAVE (STUDENT)";
            btn_CreateStudent.UseVisualStyleBackColor = false;
            btn_CreateStudent.Visible = false;
            btn_CreateStudent.Click += btn_CreateStudent_Click;
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
            btn_save.Location = new Point(304, 532);
            btn_save.Margin = new Padding(4, 3, 4, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(117, 38);
            btn_save.TabIndex = 51;
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
            btn_cancel.Location = new Point(54, 532);
            btn_cancel.Margin = new Padding(4, 3, 4, 3);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(117, 38);
            btn_cancel.TabIndex = 50;
            btn_cancel.Text = "CANCEL";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // txt_lastname_edit
            // 
            txt_lastname_edit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_lastname_edit.Location = new Point(275, 164);
            txt_lastname_edit.Margin = new Padding(4, 3, 4, 3);
            txt_lastname_edit.Name = "txt_lastname_edit";
            txt_lastname_edit.Size = new Size(164, 22);
            txt_lastname_edit.TabIndex = 49;
            txt_lastname_edit.Visible = false;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(50, 82, 21);
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_edit.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = Color.Ivory;
            btn_edit.Location = new Point(179, 532);
            btn_edit.Margin = new Padding(4, 3, 4, 3);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(117, 38);
            btn_edit.TabIndex = 47;
            btn_edit.Text = "EDIT";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // txt_email_edit
            // 
            txt_email_edit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email_edit.Location = new Point(112, 223);
            txt_email_edit.Margin = new Padding(4, 3, 4, 3);
            txt_email_edit.Name = "txt_email_edit";
            txt_email_edit.Size = new Size(326, 22);
            txt_email_edit.TabIndex = 48;
            txt_email_edit.Visible = false;
            // 
            // txt_firstname_edit
            // 
            txt_firstname_edit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_firstname_edit.Location = new Point(112, 164);
            txt_firstname_edit.Margin = new Padding(4, 3, 4, 3);
            txt_firstname_edit.Name = "txt_firstname_edit";
            txt_firstname_edit.Size = new Size(164, 22);
            txt_firstname_edit.TabIndex = 47;
            txt_firstname_edit.Visible = false;
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
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Profile";
            Size = new Size(1027, 652);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button borrow_btn;
        private Button isAdmin;
        private TextBox textBox7;
        private Label label7;
        private TextBox txt_feesOwed;
        private Label label6;
        private TextBox txt_email;
        private Label label4;
        private TextBox txt_borrowed;
        private Label label9;
        private Panel panel3;
        private ListBox lbx_borrowed;
        private Label label14;
        private TextBox txt_name;
        private TextBox txt_username;
        private Label label3;
        private Label addfromisbn_label;
        private Panel panel1;
        private Button btn_edit;
        private Label label1;
        private TextBox txt_lastname_edit;
        private TextBox txt_email_edit;
        private TextBox txt_firstname_edit;
        private Button btn_save;
        private Button btn_cancel;
        private Button btn_createStaff;
        private Button btn_CreateStudent;
        private Button setAdmin;
    }
}
