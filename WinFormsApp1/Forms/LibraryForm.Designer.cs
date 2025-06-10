namespace HomeLibrary
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            btnLogout = new Button();
            btnAddBook = new Button();
            flowBooks = new FlowLayoutPanel();
            panel1 = new Panel();
            panel5 = new Panel();
            btnExport = new Button();
            btnImport = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            splitContainerMain = new SplitContainer();
            panelSearch = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            numSearchYearTo = new NumericUpDown();
            label3 = new Label();
            numSearchRatingMax = new NumericUpDown();
            btnResetSearch = new Button();
            txtSearchTitle = new TextBox();
            btnSearch = new Button();
            label2 = new Label();
            txtSearchAuthor = new TextBox();
            numSearchYearFrom = new NumericUpDown();
            comboSearchGenre = new ComboBox();
            label4 = new Label();
            numSearchRatingMin = new NumericUpDown();
            comboSearchLanguage = new ComboBox();
            label8 = new Label();
            comboSearchStatus = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            panelSearch.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSearchYearTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSearchRatingMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSearchYearFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSearchRatingMin).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1076, 24);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 47);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddBook.BackColor = Color.White;
            btnAddBook.Cursor = Cursors.Hand;
            btnAddBook.FlatAppearance.BorderColor = Color.White;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddBook.ForeColor = Color.Orange;
            btnAddBook.Location = new Point(908, 24);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(131, 47);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // flowBooks
            // 
            flowBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowBooks.AutoScroll = true;
            flowBooks.BorderStyle = BorderStyle.FixedSingle;
            flowBooks.FlowDirection = FlowDirection.TopDown;
            flowBooks.Location = new Point(12, 12);
            flowBooks.Name = "flowBooks";
            flowBooks.Size = new Size(778, 612);
            flowBooks.TabIndex = 6;
            flowBooks.WrapContents = false;
            flowBooks.SizeChanged += FlowBooks_SizeChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnAddBook);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 100);
            panel1.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.Controls.Add(btnExport);
            panel5.Controls.Add(btnImport);
            panel5.Location = new Point(495, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(342, 77);
            panel5.TabIndex = 8;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.White;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderColor = Color.White;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExport.ForeColor = Color.Orange;
            btnExport.Location = new Point(185, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(131, 47);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.White;
            btnImport.Cursor = Cursors.Hand;
            btnImport.FlatAppearance.BorderColor = Color.White;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnImport.ForeColor = Color.Orange;
            btnImport.Location = new Point(28, 12);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(131, 47);
            btnImport.TabIndex = 7;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(47, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 77);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 21);
            label1.Name = "label1";
            label1.Size = new Size(196, 38);
            label1.TabIndex = 1;
            label1.Text = "Home Library";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 100);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(panelSearch);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(flowBooks);
            splitContainerMain.Size = new Size(1209, 636);
            splitContainerMain.SplitterDistance = 403;
            splitContainerMain.TabIndex = 8;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = SystemColors.Control;
            panelSearch.Controls.Add(panel3);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(10);
            panelSearch.Size = new Size(403, 636);
            panelSearch.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(numSearchYearTo);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(numSearchRatingMax);
            panel3.Controls.Add(btnResetSearch);
            panel3.Controls.Add(txtSearchTitle);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtSearchAuthor);
            panel3.Controls.Add(numSearchYearFrom);
            panel3.Controls.Add(comboSearchGenre);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(numSearchRatingMin);
            panel3.Controls.Add(comboSearchLanguage);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(comboSearchStatus);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(13, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 610);
            panel3.TabIndex = 36;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Top;
            panel4.ForeColor = SystemColors.ControlText;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(377, 74);
            panel4.TabIndex = 37;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(83, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.Orange;
            label9.Location = new Point(140, 21);
            label9.Name = "label9";
            label9.Size = new Size(165, 32);
            label9.TabIndex = 0;
            label9.Text = "Search Filters";
            // 
            // numSearchYearTo
            // 
            numSearchYearTo.Font = new Font("Segoe UI", 10F);
            numSearchYearTo.Location = new Point(259, 367);
            numSearchYearTo.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numSearchYearTo.Name = "numSearchYearTo";
            numSearchYearTo.Size = new Size(101, 34);
            numSearchYearTo.TabIndex = 33;
            numSearchYearTo.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(15, 103);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 21;
            label3.Text = "Title:";
            // 
            // numSearchRatingMax
            // 
            numSearchRatingMax.DecimalPlaces = 1;
            numSearchRatingMax.Font = new Font("Segoe UI", 10F);
            numSearchRatingMax.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numSearchRatingMax.Location = new Point(259, 318);
            numSearchRatingMax.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numSearchRatingMax.Name = "numSearchRatingMax";
            numSearchRatingMax.Size = new Size(101, 34);
            numSearchRatingMax.TabIndex = 31;
            numSearchRatingMax.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnResetSearch
            // 
            btnResetSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetSearch.Cursor = Cursors.Hand;
            btnResetSearch.FlatAppearance.BorderColor = Color.Orange;
            btnResetSearch.FlatStyle = FlatStyle.Flat;
            btnResetSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnResetSearch.ForeColor = Color.Orange;
            btnResetSearch.Location = new Point(210, 517);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(131, 47);
            btnResetSearch.TabIndex = 35;
            btnResetSearch.Text = "Reset";
            btnResetSearch.UseVisualStyleBackColor = true;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Font = new Font("Segoe UI", 10F);
            txtSearchTitle.Location = new Point(121, 100);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.PlaceholderText = "Title";
            txtSearchTitle.Size = new Size(219, 34);
            txtSearchTitle.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSearch.BackColor = Color.Orange;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.Orange;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(34, 517);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 47);
            btnSearch.TabIndex = 34;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(15, 148);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 22;
            label2.Text = "Author:";
            // 
            // txtSearchAuthor
            // 
            txtSearchAuthor.Font = new Font("Segoe UI", 10F);
            txtSearchAuthor.Location = new Point(121, 142);
            txtSearchAuthor.Name = "txtSearchAuthor";
            txtSearchAuthor.PlaceholderText = "Author";
            txtSearchAuthor.Size = new Size(219, 34);
            txtSearchAuthor.TabIndex = 19;
            // 
            // numSearchYearFrom
            // 
            numSearchYearFrom.Font = new Font("Segoe UI", 10F);
            numSearchYearFrom.Location = new Point(154, 367);
            numSearchYearFrom.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numSearchYearFrom.Name = "numSearchYearFrom";
            numSearchYearFrom.Size = new Size(99, 34);
            numSearchYearFrom.TabIndex = 32;
            // 
            // comboSearchGenre
            // 
            comboSearchGenre.Font = new Font("Segoe UI", 10F);
            comboSearchGenre.FormattingEnabled = true;
            comboSearchGenre.Location = new Point(154, 182);
            comboSearchGenre.Name = "comboSearchGenre";
            comboSearchGenre.Size = new Size(187, 36);
            comboSearchGenre.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(16, 190);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 23;
            label4.Text = "Genre:";
            // 
            // numSearchRatingMin
            // 
            numSearchRatingMin.DecimalPlaces = 1;
            numSearchRatingMin.Font = new Font("Segoe UI", 10F);
            numSearchRatingMin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numSearchRatingMin.Location = new Point(154, 318);
            numSearchRatingMin.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numSearchRatingMin.Name = "numSearchRatingMin";
            numSearchRatingMin.Size = new Size(99, 34);
            numSearchRatingMin.TabIndex = 30;
            // 
            // comboSearchLanguage
            // 
            comboSearchLanguage.Font = new Font("Segoe UI", 10F);
            comboSearchLanguage.FormattingEnabled = true;
            comboSearchLanguage.Location = new Point(154, 224);
            comboSearchLanguage.Name = "comboSearchLanguage";
            comboSearchLanguage.Size = new Size(187, 36);
            comboSearchLanguage.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(15, 367);
            label8.Name = "label8";
            label8.Size = new Size(112, 28);
            label8.TabIndex = 29;
            label8.Text = "Year Range:";
            // 
            // comboSearchStatus
            // 
            comboSearchStatus.Font = new Font("Segoe UI", 10F);
            comboSearchStatus.FormattingEnabled = true;
            comboSearchStatus.Location = new Point(154, 266);
            comboSearchStatus.Name = "comboSearchStatus";
            comboSearchStatus.Size = new Size(187, 36);
            comboSearchStatus.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(16, 320);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 28;
            label5.Text = "Rating Range:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(15, 269);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 26;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(15, 227);
            label7.Name = "label7";
            label7.Size = new Size(101, 28);
            label7.TabIndex = 27;
            label7.Text = "Language:";
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1209, 736);
            Controls.Add(splitContainerMain);
            Controls.Add(panel1);
            Name = "LibraryForm";
            Text = "Home Library";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSearchYearTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSearchRatingMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSearchYearFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSearchRatingMin).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogout;
        private Button btnAddBook;
        private FlowLayoutPanel flowBooks;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private SplitContainer splitContainerMain;
        private Panel panelSearch;
        private Label label7;
        private Label label6;
        private ComboBox comboSearchStatus;
        private ComboBox comboSearchLanguage;
        private Label label4;
        private Label label2;
        private Label label3;
        private ComboBox comboSearchGenre;
        private TextBox txtSearchAuthor;
        private TextBox txtSearchTitle;
        private Button btnResetSearch;
        private Button btnSearch;
        private NumericUpDown numSearchYearTo;
        private NumericUpDown numSearchYearFrom;
        private NumericUpDown numSearchRatingMax;
        private NumericUpDown numSearchRatingMin;
        private Label label8;
        private Label label5;
        private Button btnExport;
        private Button btnImport;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label9;
        private Panel panel5;
    }
}