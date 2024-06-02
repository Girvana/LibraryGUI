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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            search_datagridview = new DataGridView();
            panel2 = new Panel();
            search_txtbox = new TextBox();
            search_label = new Label();
            search_btn = new Button();
            title_label = new Label();
            author_label = new Label();
            borrow_btn = new Button();
            panel1 = new Panel();
            availaible_listbx = new ListBox();
            available_label = new Label();
            description_label = new Label();
            description_txtbox = new TextBox();
            author_txtbox = new TextBox();
            title_txtbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)search_datagridview).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // search_datagridview
            // 
            search_datagridview.AllowUserToAddRows = false;
            search_datagridview.AllowUserToDeleteRows = false;
            search_datagridview.AllowUserToResizeColumns = false;
            search_datagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            search_datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            search_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            search_datagridview.BackgroundColor = SystemColors.Control;
            search_datagridview.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            search_datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            search_datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            search_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            search_datagridview.Location = new Point(30, 58);
            search_datagridview.Margin = new Padding(4, 3, 4, 3);
            search_datagridview.MultiSelect = false;
            search_datagridview.Name = "search_datagridview";
            search_datagridview.ReadOnly = true;
            search_datagridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            search_datagridview.RowHeadersVisible = false;
            search_datagridview.RowTemplate.ReadOnly = true;
            search_datagridview.ScrollBars = ScrollBars.Vertical;
            search_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            search_datagridview.Size = new Size(933, 276);
            search_datagridview.TabIndex = 0;
            search_datagridview.RowEnter += search_datagridview_RowEnter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(search_txtbox);
            panel2.Controls.Add(search_label);
            panel2.Controls.Add(search_btn);
            panel2.Controls.Add(search_datagridview);
            panel2.Location = new Point(20, 15);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 355);
            panel2.TabIndex = 1;
            // 
            // search_txtbox
            // 
            search_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_txtbox.Location = new Point(105, 18);
            search_txtbox.Margin = new Padding(4, 3, 4, 3);
            search_txtbox.Name = "search_txtbox";
            search_txtbox.Size = new Size(697, 23);
            search_txtbox.TabIndex = 22;
            // 
            // search_label
            // 
            search_label.AutoSize = true;
            search_label.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_label.Location = new Point(26, 18);
            search_label.Margin = new Padding(4, 0, 4, 0);
            search_label.Name = "search_label";
            search_label.Size = new Size(62, 19);
            search_label.TabIndex = 3;
            search_label.Text = "Search:";
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.FromArgb(50, 82, 21);
            search_btn.FlatAppearance.BorderSize = 0;
            search_btn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            search_btn.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_btn.ForeColor = Color.Ivory;
            search_btn.Location = new Point(810, 13);
            search_btn.Margin = new Padding(4, 3, 4, 3);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(117, 38);
            search_btn.TabIndex = 16;
            search_btn.Text = "SEARCH";
            search_btn.UseVisualStyleBackColor = false;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_label.Location = new Point(33, 37);
            title_label.Margin = new Padding(4, 0, 4, 0);
            title_label.Name = "title_label";
            title_label.Size = new Size(68, 16);
            title_label.TabIndex = 8;
            title_label.Text = "Book Title:";
            // 
            // author_label
            // 
            author_label.AutoSize = true;
            author_label.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            author_label.Location = new Point(30, 83);
            author_label.Margin = new Padding(4, 0, 4, 0);
            author_label.Name = "author_label";
            author_label.Size = new Size(66, 16);
            author_label.TabIndex = 10;
            author_label.Text = "Author(s):";
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
            borrow_btn.Location = new Point(847, 189);
            borrow_btn.Margin = new Padding(4, 3, 4, 3);
            borrow_btn.Name = "borrow_btn";
            borrow_btn.Size = new Size(117, 38);
            borrow_btn.TabIndex = 17;
            borrow_btn.Text = "BORROW";
            borrow_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(availaible_listbx);
            panel1.Controls.Add(available_label);
            panel1.Controls.Add(description_label);
            panel1.Controls.Add(description_txtbox);
            panel1.Controls.Add(borrow_btn);
            panel1.Controls.Add(author_label);
            panel1.Controls.Add(title_label);
            panel1.Controls.Add(author_txtbox);
            panel1.Controls.Add(title_txtbox);
            panel1.Location = new Point(20, 389);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 243);
            panel1.TabIndex = 0;
            // 
            // availaible_listbx
            // 
            availaible_listbx.FormattingEnabled = true;
            availaible_listbx.ItemHeight = 15;
            availaible_listbx.Location = new Point(596, 59);
            availaible_listbx.Margin = new Padding(4, 3, 4, 3);
            availaible_listbx.Name = "availaible_listbx";
            availaible_listbx.Size = new Size(367, 109);
            availaible_listbx.TabIndex = 24;
            // 
            // available_label
            // 
            available_label.AutoSize = true;
            available_label.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            available_label.Location = new Point(593, 37);
            available_label.Margin = new Padding(4, 0, 4, 0);
            available_label.Name = "available_label";
            available_label.Size = new Size(63, 16);
            available_label.TabIndex = 21;
            available_label.Text = "Available:";
            // 
            // description_label
            // 
            description_label.AutoSize = true;
            description_label.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description_label.Location = new Point(26, 128);
            description_label.Margin = new Padding(4, 0, 4, 0);
            description_label.Name = "description_label";
            description_label.Size = new Size(75, 16);
            description_label.TabIndex = 20;
            description_label.Text = "Description:";
            // 
            // description_txtbox
            // 
            description_txtbox.BorderStyle = BorderStyle.None;
            description_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description_txtbox.Location = new Point(118, 128);
            description_txtbox.Margin = new Padding(4, 3, 4, 3);
            description_txtbox.Multiline = true;
            description_txtbox.Name = "description_txtbox";
            description_txtbox.ReadOnly = true;
            description_txtbox.ScrollBars = ScrollBars.Vertical;
            description_txtbox.Size = new Size(385, 99);
            description_txtbox.TabIndex = 19;
            description_txtbox.TabStop = false;
            // 
            // author_txtbox
            // 
            author_txtbox.BorderStyle = BorderStyle.None;
            author_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            author_txtbox.Location = new Point(118, 83);
            author_txtbox.Margin = new Padding(4, 3, 4, 3);
            author_txtbox.Name = "author_txtbox";
            author_txtbox.ReadOnly = true;
            author_txtbox.Size = new Size(385, 16);
            author_txtbox.TabIndex = 5;
            // 
            // title_txtbox
            // 
            title_txtbox.BorderStyle = BorderStyle.None;
            title_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_txtbox.Location = new Point(118, 37);
            title_txtbox.Margin = new Padding(4, 3, 4, 3);
            title_txtbox.Name = "title_txtbox";
            title_txtbox.ReadOnly = true;
            title_txtbox.Size = new Size(385, 16);
            title_txtbox.TabIndex = 3;
            // 
            // LibraryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LibraryView";
            Size = new Size(1027, 652);
            ((System.ComponentModel.ISupportInitialize)search_datagridview).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
