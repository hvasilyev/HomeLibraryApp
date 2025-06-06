namespace HomeLibrary
{
    partial class BookDetailsForm
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
            txtAuthor = new TextBox();
            txtDescription = new TextBox();
            txtYear = new NumericUpDown();
            pictureBox = new PictureBox();
            btnEdit = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            comboBoxGenre = new ComboBox();
            btnUploadImage = new Button();
            comboBoxLanguage = new ComboBox();
            txtNote = new TextBox();
            numRating = new NumericUpDown();
            comboBoxStatus = new ComboBox();
            lblTitleDisplay = new Label();
            lblAuthorDisplay = new Label();
            lblGenreDisplay = new Label();
            lblYearDisplay = new Label();
            lblDescriptionDisplay = new Label();
            lblLanguageDisplay = new Label();
            lblStatusDisplay = new Label();
            lblRatingDisplay = new Label();
            lblNoteDisplay = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtTitle.Location = new Point(441, 40);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(481, 55);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 12F);
            txtAuthor.Location = new Point(441, 107);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(180, 39);
            txtAuthor.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDescription.Location = new Point(453, 481);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(517, 188);
            txtDescription.TabIndex = 3;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Segoe UI", 12F);
            txtYear.Location = new Point(589, 253);
            txtYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(180, 39);
            txtYear.TabIndex = 4;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(31, 59);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(395, 491);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Orange;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(115, 734);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 47);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.ForeColor = Color.Orange;
            btnSave.Location = new Point(295, 734);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 47);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(984, 734);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 47);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.Font = new Font("Segoe UI", 12F);
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(589, 171);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(182, 40);
            comboBoxGenre.TabIndex = 9;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(138, 573);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(170, 34);
            btnUploadImage.TabIndex = 10;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.Font = new Font("Segoe UI", 12F);
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(587, 290);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(182, 40);
            comboBoxLanguage.TabIndex = 15;
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNote.Location = new Point(812, 210);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(303, 92);
            txtNote.TabIndex = 23;
            // 
            // numRating
            // 
            numRating.DecimalPlaces = 1;
            numRating.Font = new Font("Segoe UI", 12F);
            numRating.Location = new Point(589, 213);
            numRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(180, 39);
            numRating.TabIndex = 22;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("Segoe UI", 12F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(587, 332);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(182, 40);
            comboBoxStatus.TabIndex = 21;
            // 
            // lblTitleDisplay
            // 
            lblTitleDisplay.AutoEllipsis = true;
            lblTitleDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitleDisplay.Location = new Point(441, 34);
            lblTitleDisplay.Name = "lblTitleDisplay";
            lblTitleDisplay.Size = new Size(674, 61);
            lblTitleDisplay.TabIndex = 24;
            lblTitleDisplay.Text = "Title";
            // 
            // lblAuthorDisplay
            // 
            lblAuthorDisplay.AutoSize = true;
            lblAuthorDisplay.Font = new Font("Segoe UI", 12F);
            lblAuthorDisplay.Location = new Point(453, 107);
            lblAuthorDisplay.Name = "lblAuthorDisplay";
            lblAuthorDisplay.Size = new Size(87, 32);
            lblAuthorDisplay.TabIndex = 25;
            lblAuthorDisplay.Text = "Author";
            // 
            // lblGenreDisplay
            // 
            lblGenreDisplay.AutoSize = true;
            lblGenreDisplay.Font = new Font("Segoe UI", 12F);
            lblGenreDisplay.Location = new Point(589, 176);
            lblGenreDisplay.Name = "lblGenreDisplay";
            lblGenreDisplay.Size = new Size(78, 32);
            lblGenreDisplay.TabIndex = 26;
            lblGenreDisplay.Text = "Genre";
            // 
            // lblYearDisplay
            // 
            lblYearDisplay.AutoSize = true;
            lblYearDisplay.Font = new Font("Segoe UI", 12F);
            lblYearDisplay.Location = new Point(589, 253);
            lblYearDisplay.Name = "lblYearDisplay";
            lblYearDisplay.Size = new Size(58, 32);
            lblYearDisplay.TabIndex = 27;
            lblYearDisplay.Text = "Year";
            // 
            // lblDescriptionDisplay
            // 
            lblDescriptionDisplay.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDescriptionDisplay.Location = new Point(453, 481);
            lblDescriptionDisplay.Name = "lblDescriptionDisplay";
            lblDescriptionDisplay.Size = new Size(517, 188);
            lblDescriptionDisplay.TabIndex = 28;
            lblDescriptionDisplay.Text = "Description";
            // 
            // lblLanguageDisplay
            // 
            lblLanguageDisplay.AutoSize = true;
            lblLanguageDisplay.Font = new Font("Segoe UI", 12F);
            lblLanguageDisplay.Location = new Point(589, 290);
            lblLanguageDisplay.Name = "lblLanguageDisplay";
            lblLanguageDisplay.Size = new Size(118, 32);
            lblLanguageDisplay.TabIndex = 29;
            lblLanguageDisplay.Text = "Language";
            // 
            // lblStatusDisplay
            // 
            lblStatusDisplay.AutoSize = true;
            lblStatusDisplay.Font = new Font("Segoe UI", 12F);
            lblStatusDisplay.Location = new Point(589, 332);
            lblStatusDisplay.Name = "lblStatusDisplay";
            lblStatusDisplay.Size = new Size(78, 32);
            lblStatusDisplay.TabIndex = 30;
            lblStatusDisplay.Text = "Status";
            // 
            // lblRatingDisplay
            // 
            lblRatingDisplay.AutoSize = true;
            lblRatingDisplay.Font = new Font("Segoe UI", 12F);
            lblRatingDisplay.Location = new Point(589, 212);
            lblRatingDisplay.Name = "lblRatingDisplay";
            lblRatingDisplay.Size = new Size(82, 32);
            lblRatingDisplay.TabIndex = 31;
            lblRatingDisplay.Text = "Rating";
            // 
            // lblNoteDisplay
            // 
            lblNoteDisplay.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNoteDisplay.Location = new Point(812, 210);
            lblNoteDisplay.Name = "lblNoteDisplay";
            lblNoteDisplay.Size = new Size(303, 92);
            lblNoteDisplay.TabIndex = 32;
            lblNoteDisplay.Text = "Note";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label1.Location = new Point(453, 213);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 37;
            label1.Text = "Rating:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label2.Location = new Point(453, 333);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 36;
            label2.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label3.Location = new Point(453, 291);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 35;
            label3.Text = "Language:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label4.Location = new Point(453, 253);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 34;
            label4.Text = "Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label5.Location = new Point(453, 177);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 33;
            label5.Text = "Genre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(453, 422);
            label6.Name = "label6";
            label6.Size = new Size(153, 32);
            label6.TabIndex = 38;
            label6.Text = "Description:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label7.Location = new Point(807, 171);
            label7.Name = "label7";
            label7.Size = new Size(72, 32);
            label7.TabIndex = 39;
            label7.Text = "Note:";
            // 
            // BookDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1194, 827);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblNoteDisplay);
            Controls.Add(lblRatingDisplay);
            Controls.Add(lblStatusDisplay);
            Controls.Add(lblLanguageDisplay);
            Controls.Add(lblDescriptionDisplay);
            Controls.Add(lblYearDisplay);
            Controls.Add(lblGenreDisplay);
            Controls.Add(lblAuthorDisplay);
            Controls.Add(lblTitleDisplay);
            Controls.Add(txtNote);
            Controls.Add(numRating);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxLanguage);
            Controls.Add(btnUploadImage);
            Controls.Add(comboBoxGenre);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(pictureBox);
            Controls.Add(txtYear);
            Controls.Add(txtDescription);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Name = "BookDetailsForm";
            Text = "BookDetailsForm";
            ((System.ComponentModel.ISupportInitialize)txtYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtDescription;
        private NumericUpDown txtYear;
        private PictureBox pictureBox;
        private Button btnEdit;
        private Button btnSave;
        private Button btnDelete;
        private ComboBox comboBoxGenre;
        private Button btnUploadImage;
        private ComboBox comboBoxLanguage;
        private TextBox txtNote;
        private NumericUpDown numRating;
        private ComboBox comboBoxStatus;
        private Label lblTitleDisplay;
        private Label lblAuthorDisplay;
        private Label lblGenreDisplay;
        private Label lblYearDisplay;
        private Label lblDescriptionDisplay;
        private Label lblLanguageDisplay;
        private Label lblStatusDisplay;
        private Label lblRatingDisplay;
        private Label lblNoteDisplay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}