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
            panel2 = new Panel();
            btn_addMP = new Button();
            label9 = new Label();
            btn_addMD = new Button();
            txt_ISBNManual = new TextBox();
            textBox5 = new TextBox();
            txt_description = new TextBox();
            description_label = new Label();
            title_label = new Label();
            txt_title = new TextBox();
            author_label = new Label();
            txt_authors = new TextBox();
            title_txtbox = new TextBox();
            author_txtbox = new TextBox();
            label8 = new Label();
            btn_addAP = new Button();
            btn_addAD = new Button();
            panel1 = new Panel();
            label1 = new Label();
            lbx_auto = new ListBox();
            txt_ISBNAuto = new TextBox();
            addfromisbn_label = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btn_addMP);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btn_addMD);
            panel2.Controls.Add(txt_ISBNManual);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(txt_description);
            panel2.Controls.Add(description_label);
            panel2.Controls.Add(title_label);
            panel2.Controls.Add(txt_title);
            panel2.Controls.Add(author_label);
            panel2.Controls.Add(txt_authors);
            panel2.Controls.Add(title_txtbox);
            panel2.Controls.Add(author_txtbox);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(461, 22);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 606);
            panel2.TabIndex = 3;
            // 
            // btn_addMP
            // 
            btn_addMP.BackColor = Color.FromArgb(50, 82, 21);
            btn_addMP.FlatAppearance.BorderSize = 0;
            btn_addMP.FlatAppearance.CheckedBackColor = Color.SeaGreen;
            btn_addMP.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_addMP.FlatStyle = FlatStyle.Flat;
            btn_addMP.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addMP.ForeColor = Color.Ivory;
            btn_addMP.Location = new Point(140, 534);
            btn_addMP.Margin = new Padding(4, 3, 4, 3);
            btn_addMP.Name = "btn_addMP";
            btn_addMP.Size = new Size(128, 54);
            btn_addMP.TabIndex = 37;
            btn_addMP.Text = "ADD PHYSICAL COPY";
            btn_addMP.UseVisualStyleBackColor = false;
            btn_addMP.Click += btn_addMP_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 112);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(39, 16);
            label9.TabIndex = 34;
            label9.Text = "ISBN:";
            // 
            // btn_addMD
            // 
            btn_addMD.BackColor = Color.FromArgb(50, 82, 21);
            btn_addMD.FlatAppearance.BorderSize = 0;
            btn_addMD.FlatAppearance.CheckedBackColor = Color.SeaGreen;
            btn_addMD.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_addMD.FlatStyle = FlatStyle.Flat;
            btn_addMD.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addMD.ForeColor = Color.Ivory;
            btn_addMD.Location = new Point(307, 534);
            btn_addMD.Margin = new Padding(4, 3, 4, 3);
            btn_addMD.Name = "btn_addMD";
            btn_addMD.Size = new Size(117, 54);
            btn_addMD.TabIndex = 38;
            btn_addMD.Text = " ADD DIGITAL COPY";
            btn_addMD.UseVisualStyleBackColor = false;
            btn_addMD.Click += btn_addMD_Click;
            // 
            // txt_ISBNManual
            // 
            txt_ISBNManual.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ISBNManual.Location = new Point(21, 131);
            txt_ISBNManual.Margin = new Padding(4, 3, 4, 3);
            txt_ISBNManual.Name = "txt_ISBNManual";
            txt_ISBNManual.Size = new Size(496, 23);
            txt_ISBNManual.TabIndex = 33;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(56, 134);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(222, 16);
            textBox5.TabIndex = 33;
            // 
            // txt_description
            // 
            txt_description.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_description.Location = new Point(21, 292);
            txt_description.Margin = new Padding(4, 3, 4, 3);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(496, 222);
            txt_description.TabIndex = 31;
            // 
            // description_label
            // 
            description_label.AutoSize = true;
            description_label.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description_label.Location = new Point(21, 273);
            description_label.Margin = new Padding(4, 0, 4, 0);
            description_label.Name = "description_label";
            description_label.Size = new Size(75, 16);
            description_label.TabIndex = 32;
            description_label.Text = "Description:";
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_label.Location = new Point(21, 165);
            title_label.Margin = new Padding(4, 0, 4, 0);
            title_label.Name = "title_label";
            title_label.Size = new Size(68, 16);
            title_label.TabIndex = 29;
            title_label.Text = "Book Title:";
            // 
            // txt_title
            // 
            txt_title.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_title.Location = new Point(21, 184);
            txt_title.Margin = new Padding(4, 3, 4, 3);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(496, 23);
            txt_title.TabIndex = 27;
            // 
            // author_label
            // 
            author_label.AutoSize = true;
            author_label.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            author_label.Location = new Point(21, 224);
            author_label.Margin = new Padding(4, 0, 4, 0);
            author_label.Name = "author_label";
            author_label.Size = new Size(203, 16);
            author_label.TabIndex = 30;
            author_label.Text = "Author(s) (Separated by commas:";
            // 
            // txt_authors
            // 
            txt_authors.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_authors.Location = new Point(21, 243);
            txt_authors.Margin = new Padding(4, 3, 4, 3);
            txt_authors.Name = "txt_authors";
            txt_authors.Size = new Size(496, 23);
            txt_authors.TabIndex = 28;
            // 
            // title_txtbox
            // 
            title_txtbox.BorderStyle = BorderStyle.None;
            title_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_txtbox.Location = new Point(90, 178);
            title_txtbox.Margin = new Padding(4, 3, 4, 3);
            title_txtbox.Name = "title_txtbox";
            title_txtbox.Size = new Size(188, 16);
            title_txtbox.TabIndex = 27;
            // 
            // author_txtbox
            // 
            author_txtbox.BorderStyle = BorderStyle.None;
            author_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            author_txtbox.Location = new Point(90, 224);
            author_txtbox.Margin = new Padding(4, 3, 4, 3);
            author_txtbox.Name = "author_txtbox";
            author_txtbox.Size = new Size(188, 16);
            author_txtbox.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 62);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(121, 23);
            label8.TabIndex = 14;
            label8.Text = "Manual Entry";
            // 
            // btn_addAP
            // 
            btn_addAP.BackColor = Color.FromArgb(50, 82, 21);
            btn_addAP.FlatAppearance.BorderSize = 0;
            btn_addAP.FlatAppearance.CheckedBackColor = Color.SeaGreen;
            btn_addAP.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_addAP.FlatStyle = FlatStyle.Flat;
            btn_addAP.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addAP.ForeColor = Color.Ivory;
            btn_addAP.Location = new Point(59, 535);
            btn_addAP.Margin = new Padding(4, 3, 4, 3);
            btn_addAP.Name = "btn_addAP";
            btn_addAP.Size = new Size(128, 54);
            btn_addAP.TabIndex = 12;
            btn_addAP.Text = "ADD PHYSICAL COPY";
            btn_addAP.UseVisualStyleBackColor = false;
            btn_addAP.Click += btn_addAP_Click;
            // 
            // btn_addAD
            // 
            btn_addAD.BackColor = Color.FromArgb(50, 82, 21);
            btn_addAD.FlatAppearance.BorderSize = 0;
            btn_addAD.FlatAppearance.CheckedBackColor = Color.SeaGreen;
            btn_addAD.FlatAppearance.MouseDownBackColor = Color.SeaGreen;
            btn_addAD.FlatStyle = FlatStyle.Flat;
            btn_addAD.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addAD.ForeColor = Color.Ivory;
            btn_addAD.Location = new Point(226, 535);
            btn_addAD.Margin = new Padding(4, 3, 4, 3);
            btn_addAD.Name = "btn_addAD";
            btn_addAD.Size = new Size(117, 54);
            btn_addAD.TabIndex = 13;
            btn_addAD.Text = " ADD DIGITAL COPY";
            btn_addAD.UseVisualStyleBackColor = false;
            btn_addAD.Click += btn_addAD_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbx_auto);
            panel1.Controls.Add(txt_ISBNAuto);
            panel1.Controls.Add(addfromisbn_label);
            panel1.Controls.Add(btn_addAP);
            panel1.Controls.Add(btn_addAD);
            panel1.Location = new Point(26, 22);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 607);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 132);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 16);
            label1.TabIndex = 36;
            label1.Text = "ISBN:";
            // 
            // lbx_auto
            // 
            lbx_auto.FormattingEnabled = true;
            lbx_auto.ItemHeight = 15;
            lbx_auto.Location = new Point(26, 166);
            lbx_auto.Margin = new Padding(4, 3, 4, 3);
            lbx_auto.Name = "lbx_auto";
            lbx_auto.Size = new Size(373, 349);
            lbx_auto.TabIndex = 28;
            lbx_auto.SelectedIndexChanged += lbx_auto_SelectedIndexChanged;
            // 
            // txt_ISBNAuto
            // 
            txt_ISBNAuto.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ISBNAuto.Location = new Point(76, 132);
            txt_ISBNAuto.Margin = new Padding(4, 3, 4, 3);
            txt_ISBNAuto.Name = "txt_ISBNAuto";
            txt_ISBNAuto.Size = new Size(322, 23);
            txt_ISBNAuto.TabIndex = 35;
            // 
            // addfromisbn_label
            // 
            addfromisbn_label.AutoSize = true;
            addfromisbn_label.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addfromisbn_label.Location = new Point(118, 63);
            addfromisbn_label.Margin = new Padding(4, 0, 4, 0);
            addfromisbn_label.Name = "addfromisbn_label";
            addfromisbn_label.Size = new Size(136, 23);
            addfromisbn_label.TabIndex = 27;
            addfromisbn_label.Text = "Add from ISBN";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddBooks";
            Size = new Size(1027, 652);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addAP;
        private System.Windows.Forms.Button btn_addAD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addfromisbn_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ISBNManual;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.TextBox txt_authors;
        private System.Windows.Forms.TextBox title_txtbox;
        private System.Windows.Forms.TextBox author_txtbox;
        private System.Windows.Forms.ListBox lbx_auto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ISBNAuto;
        private System.Windows.Forms.Button btn_addMP;
        private System.Windows.Forms.Button btn_addMD;
    }
}
