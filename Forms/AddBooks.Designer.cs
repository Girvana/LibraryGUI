namespace LibraryGUI
{
    partial class AddBooks
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.add1_btn = new System.Windows.Forms.Button();
            this.add2_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addfromisbn_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.author_txtbox = new System.Windows.Forms.TextBox();
            this.title_txtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.author1_txtbox = new System.Windows.Forms.TextBox();
            this.title1_txtbox = new System.Windows.Forms.TextBox();
            this.description_txtbox = new System.Windows.Forms.TextBox();
            this.isbn1_txtbox = new System.Windows.Forms.TextBox();
            this.isbn_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isbn2_txtbox = new System.Windows.Forms.TextBox();
            this.add3_btn = new System.Windows.Forms.Button();
            this.add4_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.add3_btn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.add4_btn);
            this.panel2.Controls.Add(this.isbn1_txtbox);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.description_txtbox);
            this.panel2.Controls.Add(this.description_label);
            this.panel2.Controls.Add(this.title_label);
            this.panel2.Controls.Add(this.title1_txtbox);
            this.panel2.Controls.Add(this.author_label);
            this.panel2.Controls.Add(this.author1_txtbox);
            this.panel2.Controls.Add(this.title_txtbox);
            this.panel2.Controls.Add(this.author_txtbox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(395, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 526);
            this.panel2.TabIndex = 3;
            // 
            // add1_btn
            // 
            this.add1_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(21)))));
            this.add1_btn.FlatAppearance.BorderSize = 0;
            this.add1_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.add1_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.add1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add1_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add1_btn.ForeColor = System.Drawing.Color.Ivory;
            this.add1_btn.Location = new System.Drawing.Point(51, 464);
            this.add1_btn.Name = "add1_btn";
            this.add1_btn.Size = new System.Drawing.Size(110, 47);
            this.add1_btn.TabIndex = 12;
            this.add1_btn.Text = "ADD PHYSICAL COPY";
            this.add1_btn.UseVisualStyleBackColor = false;
            this.add1_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // add2_btn
            // 
            this.add2_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(21)))));
            this.add2_btn.FlatAppearance.BorderSize = 0;
            this.add2_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.add2_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.add2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add2_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add2_btn.ForeColor = System.Drawing.Color.Ivory;
            this.add2_btn.Location = new System.Drawing.Point(194, 464);
            this.add2_btn.Name = "add2_btn";
            this.add2_btn.Size = new System.Drawing.Size(100, 47);
            this.add2_btn.TabIndex = 13;
            this.add2_btn.Text = " ADD DIGITAL COPY";
            this.add2_btn.UseVisualStyleBackColor = false;
            this.add2_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Manual Entry";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.isbn_listbox);
            this.panel1.Controls.Add(this.isbn2_txtbox);
            this.panel1.Controls.Add(this.addfromisbn_label);
            this.panel1.Controls.Add(this.add1_btn);
            this.panel1.Controls.Add(this.add2_btn);
            this.panel1.Location = new System.Drawing.Point(22, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 526);
            this.panel1.TabIndex = 2;
            // 
            // addfromisbn_label
            // 
            this.addfromisbn_label.AutoSize = true;
            this.addfromisbn_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfromisbn_label.Location = new System.Drawing.Point(101, 55);
            this.addfromisbn_label.Name = "addfromisbn_label";
            this.addfromisbn_label.Size = new System.Drawing.Size(136, 23);
            this.addfromisbn_label.TabIndex = 27;
            this.addfromisbn_label.Text = "Add from ISBN";
            this.addfromisbn_label.Click += new System.EventHandler(this.label7_Click);
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(5, 237);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(75, 16);
            this.description_label.TabIndex = 32;
            this.description_label.Text = "Description:";
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_label.Location = new System.Drawing.Point(5, 194);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(66, 16);
            this.author_label.TabIndex = 30;
            this.author_label.Text = "Author(s):";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(3, 154);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(68, 16);
            this.title_label.TabIndex = 29;
            this.title_label.Text = "Book Title:";
            // 
            // author_txtbox
            // 
            this.author_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.author_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_txtbox.Location = new System.Drawing.Point(77, 194);
            this.author_txtbox.Name = "author_txtbox";
            this.author_txtbox.Size = new System.Drawing.Size(161, 16);
            this.author_txtbox.TabIndex = 28;
            // 
            // title_txtbox
            // 
            this.title_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_txtbox.Location = new System.Drawing.Point(77, 154);
            this.title_txtbox.Name = "title_txtbox";
            this.title_txtbox.Size = new System.Drawing.Size(161, 16);
            this.title_txtbox.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "ISBN:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(48, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 16);
            this.textBox5.TabIndex = 33;
            // 
            // author1_txtbox
            // 
            this.author1_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author1_txtbox.Location = new System.Drawing.Point(86, 194);
            this.author1_txtbox.Name = "author1_txtbox";
            this.author1_txtbox.Size = new System.Drawing.Size(358, 23);
            this.author1_txtbox.TabIndex = 28;
            // 
            // title1_txtbox
            // 
            this.title1_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1_txtbox.Location = new System.Drawing.Point(86, 154);
            this.title1_txtbox.Name = "title1_txtbox";
            this.title1_txtbox.Size = new System.Drawing.Size(358, 23);
            this.title1_txtbox.TabIndex = 27;
            // 
            // description_txtbox
            // 
            this.description_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_txtbox.Location = new System.Drawing.Point(86, 237);
            this.description_txtbox.Multiline = true;
            this.description_txtbox.Name = "description_txtbox";
            this.description_txtbox.Size = new System.Drawing.Size(358, 130);
            this.description_txtbox.TabIndex = 31;
            // 
            // isbn1_txtbox
            // 
            this.isbn1_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn1_txtbox.Location = new System.Drawing.Point(86, 116);
            this.isbn1_txtbox.Name = "isbn1_txtbox";
            this.isbn1_txtbox.Size = new System.Drawing.Size(358, 23);
            this.isbn1_txtbox.TabIndex = 33;
            // 
            // isbn_listbox
            // 
            this.isbn_listbox.FormattingEnabled = true;
            this.isbn_listbox.Location = new System.Drawing.Point(22, 144);
            this.isbn_listbox.Name = "isbn_listbox";
            this.isbn_listbox.Size = new System.Drawing.Size(320, 303);
            this.isbn_listbox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "ISBN:";
            // 
            // isbn2_txtbox
            // 
            this.isbn2_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn2_txtbox.Location = new System.Drawing.Point(65, 114);
            this.isbn2_txtbox.Name = "isbn2_txtbox";
            this.isbn2_txtbox.Size = new System.Drawing.Size(277, 23);
            this.isbn2_txtbox.TabIndex = 35;
            // 
            // add3_btn
            // 
            this.add3_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(21)))));
            this.add3_btn.FlatAppearance.BorderSize = 0;
            this.add3_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.add3_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.add3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add3_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add3_btn.ForeColor = System.Drawing.Color.Ivory;
            this.add3_btn.Location = new System.Drawing.Point(120, 463);
            this.add3_btn.Name = "add3_btn";
            this.add3_btn.Size = new System.Drawing.Size(110, 47);
            this.add3_btn.TabIndex = 37;
            this.add3_btn.Text = "ADD PHYSICAL COPY";
            this.add3_btn.UseVisualStyleBackColor = false;
            // 
            // add4_btn
            // 
            this.add4_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(21)))));
            this.add4_btn.FlatAppearance.BorderSize = 0;
            this.add4_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.add4_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.add4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add4_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add4_btn.ForeColor = System.Drawing.Color.Ivory;
            this.add4_btn.Location = new System.Drawing.Point(263, 463);
            this.add4_btn.Name = "add4_btn";
            this.add4_btn.Size = new System.Drawing.Size(100, 47);
            this.add4_btn.TabIndex = 38;
            this.add4_btn.Text = " ADD DIGITAL COPY";
            this.add4_btn.UseVisualStyleBackColor = false;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddBooks";
            this.Size = new System.Drawing.Size(880, 565);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add1_btn;
        private System.Windows.Forms.Button add2_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addfromisbn_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox isbn1_txtbox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox description_txtbox;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox title1_txtbox;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.TextBox author1_txtbox;
        private System.Windows.Forms.TextBox title_txtbox;
        private System.Windows.Forms.TextBox author_txtbox;
        private System.Windows.Forms.ListBox isbn_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isbn2_txtbox;
        private System.Windows.Forms.Button add3_btn;
        private System.Windows.Forms.Button add4_btn;
    }
}
