namespace LibraryGUI
{
    partial class LibraryView
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
            this.search_datagridview = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search_label = new System.Windows.Forms.Label();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.borrow_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.author_txtbox = new System.Windows.Forms.TextBox();
            this.title_txtbox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.description_txtbox = new System.Windows.Forms.TextBox();
            this.available_label = new System.Windows.Forms.Label();
            this.availaible_listbx = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.search_datagridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_datagridview
            // 
            this.search_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_datagridview.Location = new System.Drawing.Point(26, 50);
            this.search_datagridview.Name = "search_datagridview";
            this.search_datagridview.Size = new System.Drawing.Size(800, 239);
            this.search_datagridview.TabIndex = 0;
            this.search_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.search_txtbox);
            this.panel2.Controls.Add(this.search_label);
            this.panel2.Controls.Add(this.search_btn);
            this.panel2.Controls.Add(this.search_datagridview);
            this.panel2.Location = new System.Drawing.Point(17, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 308);
            this.panel2.TabIndex = 1;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.Location = new System.Drawing.Point(22, 16);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(62, 19);
            this.search_label.TabIndex = 3;
            this.search_label.Text = "Search:";
            this.search_label.Click += new System.EventHandler(this.label11_Click);
            // 
            // search_txtbox
            // 
            this.search_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txtbox.Location = new System.Drawing.Point(90, 16);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(598, 23);
            this.search_txtbox.TabIndex = 22;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(27, 35);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(68, 16);
            this.title_label.TabIndex = 8;
            this.title_label.Text = "Book Title:";
            this.title_label.Click += new System.EventHandler(this.label6_Click);
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_label.Location = new System.Drawing.Point(29, 75);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(66, 16);
            this.author_label.TabIndex = 10;
            this.author_label.Text = "Author(s):";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(21)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Ivory;
            this.search_btn.Location = new System.Drawing.Point(694, 11);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(100, 33);
            this.search_btn.TabIndex = 16;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // borrow_btn
            // 
            this.borrow_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(21)))));
            this.borrow_btn.FlatAppearance.BorderSize = 0;
            this.borrow_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.borrow_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.borrow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_btn.ForeColor = System.Drawing.Color.Ivory;
            this.borrow_btn.Location = new System.Drawing.Point(726, 164);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(100, 33);
            this.borrow_btn.TabIndex = 17;
            this.borrow_btn.Text = "BORROW";
            this.borrow_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.availaible_listbx);
            this.panel1.Controls.Add(this.available_label);
            this.panel1.Controls.Add(this.description_label);
            this.panel1.Controls.Add(this.description_txtbox);
            this.panel1.Controls.Add(this.borrow_btn);
            this.panel1.Controls.Add(this.author_label);
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Controls.Add(this.author_txtbox);
            this.panel1.Controls.Add(this.title_txtbox);
            this.panel1.Location = new System.Drawing.Point(17, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 211);
            this.panel1.TabIndex = 0;
            // 
            // author_txtbox
            // 
            this.author_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.author_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_txtbox.Location = new System.Drawing.Point(101, 72);
            this.author_txtbox.Name = "author_txtbox";
            this.author_txtbox.Size = new System.Drawing.Size(330, 16);
            this.author_txtbox.TabIndex = 5;
            // 
            // title_txtbox
            // 
            this.title_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_txtbox.Location = new System.Drawing.Point(101, 32);
            this.title_txtbox.Name = "title_txtbox";
            this.title_txtbox.Size = new System.Drawing.Size(330, 16);
            this.title_txtbox.TabIndex = 3;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(20, 118);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(75, 16);
            this.description_label.TabIndex = 20;
            this.description_label.Text = "Description:";
            this.description_label.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // description_txtbox
            // 
            this.description_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description_txtbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_txtbox.Location = new System.Drawing.Point(101, 111);
            this.description_txtbox.Multiline = true;
            this.description_txtbox.Name = "description_txtbox";
            this.description_txtbox.Size = new System.Drawing.Size(330, 86);
            this.description_txtbox.TabIndex = 19;
            // 
            // available_label
            // 
            this.available_label.AutoSize = true;
            this.available_label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_label.Location = new System.Drawing.Point(508, 32);
            this.available_label.Name = "available_label";
            this.available_label.Size = new System.Drawing.Size(63, 16);
            this.available_label.TabIndex = 21;
            this.available_label.Text = "Available:";
            // 
            // availaible_listbx
            // 
            this.availaible_listbx.FormattingEnabled = true;
            this.availaible_listbx.Location = new System.Drawing.Point(511, 51);
            this.availaible_listbx.Name = "availaible_listbx";
            this.availaible_listbx.Size = new System.Drawing.Size(315, 95);
            this.availaible_listbx.TabIndex = 24;
            // 
            // IssuedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IssuedBooks";
            this.Size = new System.Drawing.Size(880, 565);
            ((System.ComponentModel.ISupportInitialize)(this.search_datagridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView search_datagridview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox author_txtbox;
        private System.Windows.Forms.TextBox title_txtbox;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox description_txtbox;
        private System.Windows.Forms.Label available_label;
        private System.Windows.Forms.ListBox availaible_listbx;
    }
}
