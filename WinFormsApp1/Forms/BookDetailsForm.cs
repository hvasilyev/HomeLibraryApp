using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeLibrary.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HomeLibrary
{
    public partial class BookDetailsForm : Form
    {
        private Book originalBook;
        private string currentUser;
        private string selectedImagePath = "";
        public BookDetailsForm(Book book, string username)
        {
            InitializeComponent();

            originalBook = book;
            currentUser = username;

            FillFields(book);
            ToggleEditMode(false);
            SetupImageDragDrop();
        }

        private void FillFields(Book book)
        {

            // Text fields
            lblTitleDisplay.Text = txtTitle.Text = book.Title;
            lblAuthorDisplay.Text = txtAuthor.Text = book.Author;
            lblDescriptionDisplay.Text = txtDescription.Text = book.Description;
            lblNoteDisplay.Text = txtNote.Text = book.Note;

            // Combo boxes
            comboBoxGenre.DataSource = Enum.GetValues(typeof(Genre));
            comboBoxGenre.SelectedItem = book.Genre;
            lblGenreDisplay.Text = book.Genre.ToString();

            comboBoxLanguage.DataSource = Enum.GetValues(typeof(Language));
            comboBoxLanguage.SelectedItem = book.Language;
            lblLanguageDisplay.Text = book.Language.ToString();

            comboBoxStatus.DataSource = Enum.GetValues(typeof(BookStatus));
            comboBoxStatus.SelectedItem = book.Status;
            lblStatusDisplay.Text = book.Status.ToString();

            // Year & Rating
            txtYear.Value = book.Year;
            lblYearDisplay.Text = book.Year.ToString();

            numRating.Value = (decimal)book.Rating;
            lblRatingDisplay.Text = book.Rating.ToString("0.0");

            // Image
            pictureBox.Image = !string.IsNullOrEmpty(book.ImagePath) && File.Exists(book.ImagePath)
                ? Image.FromFile(book.ImagePath)
                : Image.FromFile("default_book.jpg");
        }

        private void ToggleEditMode(bool enabled)
        {
            // TextBoxes <-> Labels
            ToggleField(txtTitle, lblTitleDisplay, enabled);
            ToggleField(txtAuthor, lblAuthorDisplay, enabled);
            ToggleField(txtDescription, lblDescriptionDisplay, enabled);
            ToggleField(txtNote, lblNoteDisplay, enabled);

            // ComboBoxes <-> Labels
            ToggleField(comboBoxGenre, lblGenreDisplay, enabled);
            ToggleField(comboBoxLanguage, lblLanguageDisplay, enabled);
            ToggleField(comboBoxStatus, lblStatusDisplay, enabled);

            // NumericUpDown <-> Label
            ToggleField(txtYear, lblYearDisplay, enabled);
            ToggleField(numRating, lblRatingDisplay, enabled);

            btnSave.Enabled = enabled;
            btnUploadImage.Enabled = enabled;
        }

        private void ToggleField(Control editControl, Control viewLabel, bool editMode)
        {
            editControl.Visible = editMode;
            viewLabel.Visible = !editMode;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleEditMode(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var updatedBook = new Book
            {
                Id = originalBook.Id,
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Genre = (Genre)comboBoxGenre.SelectedItem,
                Language = (Language)comboBoxLanguage.SelectedItem,
                Status = (BookStatus)comboBoxStatus.SelectedItem,
                Rating = (double)numRating.Value,
                Year = (int)txtYear.Value,
                Description = txtDescription.Text,
                Note = txtNote.Text,
                ImagePath = string.IsNullOrWhiteSpace(selectedImagePath) ? originalBook.ImagePath : selectedImagePath
            };

            lblTitleDisplay.Text = txtTitle.Text;
            lblAuthorDisplay.Text = txtAuthor.Text;
            lblGenreDisplay.Text = comboBoxGenre.SelectedItem.ToString();
            lblLanguageDisplay.Text = comboBoxLanguage.SelectedItem.ToString();
            lblStatusDisplay.Text = comboBoxStatus.SelectedItem.ToString();
            lblYearDisplay.Text = txtYear.Value.ToString();
            lblRatingDisplay.Text = numRating.Value.ToString("0.0");
            lblDescriptionDisplay.Text = txtDescription.Text;
            lblNoteDisplay.Text = txtNote.Text;

            LibraryStorage.UpdateBook(currentUser, originalBook, updatedBook);
            originalBook = updatedBook;
            ToggleEditMode(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Delete this book?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                LibraryStorage.DeleteBook(currentUser, originalBook);
                this.Close();
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        selectedImagePath = ofd.FileName;
                        pictureBox.Image = Image.FromFile(selectedImagePath);
                    }
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Image Size is too big. Upload other image.");
                }

            }
        }

        private void SetupImageDragDrop()
        {
            pictureBox.AllowDrop = true;

            pictureBox.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    e.Effect = DragDropEffects.Copy;
            };

            pictureBox.DragDrop += (s, e) =>
            {
                try
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (files.Length > 0 && File.Exists(files[0]))
                    {
                        selectedImagePath = files[0];
                        pictureBox.Image = Image.FromFile(selectedImagePath);
                    }
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Image Size is too big. Upload other image.");
                }

            };
        }
    }
}
