namespace HomeLibrary
{
    partial class AddBookForm
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
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            btnUploadImage = new Button();
            btnAddBook = new Button();
            numYear = new NumericUpDown();
            pictureBoxPreview = new PictureBox();
            comboBoxGenre = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxLanguage = new ComboBox();
            comboBoxStatus = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            numRating = new NumericUpDown();
            label8 = new Label();
            txtNote = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.Location = new Point(595, 42);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(286, 39);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(468, 452);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(376, 179);
            txtDescription.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 12F);
            txtAuthor.Location = new Point(595, 87);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Author";
            txtAuthor.Size = new Size(286, 39);
            txtAuthor.TabIndex = 3;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(138, 536);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(147, 34);
            btnUploadImage.TabIndex = 4;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.Orange;
            btnAddBook.Cursor = Cursors.Hand;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(568, 733);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(163, 70);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // numYear
            // 
            numYear.Font = new Font("Segoe UI", 12F);
            numYear.Location = new Point(593, 178);
            numYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(180, 39);
            numYear.TabIndex = 6;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPreview.Location = new Point(36, 34);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(367, 475);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 7;
            pictureBoxPreview.TabStop = false;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.Font = new Font("Segoe UI", 12F);
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(593, 132);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(182, 40);
            comboBoxGenre.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label1.Location = new Point(468, 49);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 9;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label2.Location = new Point(468, 90);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 10;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label3.Location = new Point(468, 180);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
            label3.TabIndex = 11;
            label3.Text = "Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label4.Location = new Point(468, 135);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 12;
            label4.Text = "Genre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(468, 393);
            label5.Name = "label5";
            label5.Size = new Size(153, 32);
            label5.TabIndex = 13;
            label5.Text = "Description:";
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.Font = new Font("Segoe UI", 12F);
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(595, 268);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(182, 40);
            comboBoxLanguage.TabIndex = 14;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("Segoe UI", 12F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(595, 314);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(182, 40);
            comboBoxStatus.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label6.Location = new Point(468, 322);
            label6.Name = "label6";
            label6.Size = new Size(83, 32);
            label6.TabIndex = 16;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label7.Location = new Point(468, 271);
            label7.Name = "label7";
            label7.Size = new Size(123, 32);
            label7.TabIndex = 17;
            label7.Text = "Language:";
            // 
            // numRating
            // 
            numRating.DecimalPlaces = 1;
            numRating.Font = new Font("Segoe UI", 12F);
            numRating.Location = new Point(597, 223);
            numRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(180, 39);
            numRating.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label8.Location = new Point(468, 225);
            label8.Name = "label8";
            label8.Size = new Size(87, 32);
            label8.TabIndex = 19;
            label8.Text = "Rating:";
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Segoe UI", 10F);
            txtNote.Location = new Point(876, 452);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(298, 118);
            txtNote.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label9.Location = new Point(876, 393);
            label9.Name = "label9";
            label9.Size = new Size(72, 32);
            label9.TabIndex = 21;
            label9.Text = "Note:";
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1219, 848);
            Controls.Add(label9);
            Controls.Add(txtNote);
            Controls.Add(label8);
            Controls.Add(numRating);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxLanguage);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxGenre);
            Controls.Add(pictureBoxPreview);
            Controls.Add(numYear);
            Controls.Add(btnAddBook);
            Controls.Add(btnUploadImage);
            Controls.Add(txtAuthor);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Name = "AddBookForm";
            Text = "AddBookForm";
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private Button btnUploadImage;
        private Button btnAddBook;
        private NumericUpDown numYear;
        private PictureBox pictureBoxPreview;
        private ComboBox comboBoxGenre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxLanguage;
        private ComboBox comboBoxStatus;
        private Label label6;
        private Label label7;
        private NumericUpDown numRating;
        private Label label8;
        private TextBox txtNote;
        private Label label9;
    }
}