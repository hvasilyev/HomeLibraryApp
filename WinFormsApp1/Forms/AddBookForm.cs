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

namespace HomeLibrary
{
    public partial class AddBookForm : Form
    {
        private string selectedImagePath = "";
        private string currentUser;

        public AddBookForm(string username)
        {
            InitializeComponent();
            pictureBoxPreview.Image = Image.FromFile("default_book.jpg");
            comboBoxGenre.DataSource = Enum.GetValues(typeof(Genre));
            comboBoxLanguage.DataSource = Enum.GetValues(typeof(Language));
            comboBoxStatus.DataSource = Enum.GetValues(typeof(BookStatus));

            currentUser = username;

            pictureBoxPreview.AllowDrop = true;

            pictureBoxPreview.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    e.Effect = DragDropEffects.Copy;
            };

            pictureBoxPreview.DragDrop += (s, e) =>
            {
                try
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (files.Length > 0 && File.Exists(files[0]))
                    {
                        selectedImagePath = files[0];
                        pictureBoxPreview.Image = Image.FromFile(selectedImagePath);
                    }
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Image Size is too big. Upload other image.");
                }

            };
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    pictureBoxPreview.Image = Image.FromFile(selectedImagePath);
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Image Size is too big. Upload other image.");
            }

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Fields for Title and Author cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var book = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Genre = (Genre)comboBoxGenre.SelectedItem,
                Year = (int)numYear.Value,
                Description = txtDescription.Text,
                ImagePath = string.IsNullOrWhiteSpace(selectedImagePath) ? "" : selectedImagePath,
                Language = (Language)comboBoxLanguage.SelectedItem,
                Rating = (double)numRating.Value,
                Status = (BookStatus)comboBoxStatus.SelectedItem,
                Note = txtNote.Text
            };

            LibraryStorage.AddBook(currentUser, book);
            Close();
        }
    }
}
