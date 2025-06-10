using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeLibrary.Forms;
using HomeLibrary.Models;


namespace HomeLibrary
{
    public partial class LibraryForm : Form
    {
        private string currentUser;

        // Search state
        string title;
        string author;
        Genre? genre;
        Language? language;
        BookStatus? status;
        int? yearFrom;
        int? yearTo;
        double? minRating;
        double? maxRating;

        public LibraryForm(string username)
        {
            InitializeComponent();
            currentUser = username;
            LoadBooks();

            comboSearchGenre.DataSource = new List<object> { "Any" }.Concat(Enum.GetValues(typeof(Genre)).Cast<object>()).ToList();
            comboSearchLanguage.DataSource = new List<object> { "Any" }.Concat(Enum.GetValues(typeof(Language)).Cast<object>()).ToList();
            comboSearchStatus.DataSource = new List<object> { "Any" }.Concat(Enum.GetValues(typeof(BookStatus)).Cast<object>()).ToList();
        }

        private void LoadBooks()
        {
            flowBooks.Controls.Clear();
            var books = LibraryStorage.LoadBooks(currentUser);

            foreach (var book in books)
            {
                var card = new BookCardControl(book);
                card.Width = flowBooks.ClientSize.Width - card.Margin.Horizontal;
                card.Height = 150;

                card.BookClicked += (s, e) =>
                {
                    var detailsForm = new BookDetailsForm(book, currentUser);
                    detailsForm.FormClosed += (sender, args) => LoadBooks();
                    detailsForm.ShowDialog();
                };

                flowBooks.Controls.Add(card);
            }
        }

        private void FlowBooks_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flowBooks.Controls)
            {
                control.Width = flowBooks.ClientSize.Width - control.Margin.Horizontal;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms["Login"]?.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm(currentUser);
            addBookForm.FormClosed += (s, args) =>
            {
                var filteredBooks = LibraryStorage.SearchBooks(currentUser, title, author, genre, language, status, yearFrom, yearTo, minRating, maxRating);
                DisplayBooks(filteredBooks);
            };
            addBookForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            title = txtSearchTitle.Text.Trim();
            author = txtSearchAuthor.Text.Trim();
            genre = comboSearchGenre.SelectedItem is Genre g ? g : null;
            language = comboSearchLanguage.SelectedItem is Language l ? l : null;
            status = comboSearchStatus.SelectedItem is BookStatus s ? s : null;

            yearFrom = numSearchYearFrom.Value > 0 ? (int?)numSearchYearFrom.Value : null;
            yearTo = numSearchYearTo.Value > 0 ? (int?)numSearchYearTo.Value : null;
            minRating = numSearchRatingMin.Value > 0 ? (double?)numSearchRatingMin.Value : null;
            maxRating = numSearchRatingMax.Value > 0 ? (double?)numSearchRatingMax.Value : null;

            if (minRating.HasValue && maxRating.HasValue && minRating > maxRating)
            {
                MessageBox.Show("Minimum rating cannot be greater than maximum rating.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (yearFrom.HasValue && yearTo.HasValue && yearFrom > yearTo)
            {
                MessageBox.Show("Start year cannot be greater than end year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filteredBooks = LibraryStorage.SearchBooks(currentUser, title, author, genre, language, status, yearFrom, yearTo, minRating, maxRating);
            DisplayBooks(filteredBooks);
        }

        private void DisplayBooks(List<Book> books)
        {
            flowBooks.Controls.Clear();

            foreach (var book in books)
            {
                var card = new BookCardControl(book);
                card.Width = flowBooks.ClientSize.Width - card.Margin.Horizontal;
                card.Height = 150;

                card.BookClicked += (s, e) =>
                {
                    var detailsForm = new BookDetailsForm(book, currentUser);
                    detailsForm.FormClosed += (sender, args) =>
                    {
                        var updatedBooks = LibraryStorage.SearchBooks(currentUser, title, author, genre, language, status, yearFrom, yearTo, minRating, maxRating);
                        DisplayBooks(updatedBooks);
                    };
                    detailsForm.ShowDialog();
                };

                flowBooks.Controls.Add(card);
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            ResetSearchFields();
            ClearSearchFilterState();
            LoadBooks();
        }

        private void ResetSearchFields()
        {
            txtSearchTitle.Clear();
            txtSearchAuthor.Clear();

            comboSearchGenre.SelectedIndex = 0;
            comboSearchLanguage.SelectedIndex = 0;
            comboSearchStatus.SelectedIndex = 0;

            numSearchYearFrom.Value = 0;
            numSearchYearTo.Value = 2025;
            numSearchRatingMin.Value = 0;
            numSearchRatingMax.Value = 10;
        }

        private void ClearSearchFilterState()
        {
            title = "";
            author = "";
            genre = null;
            language = null;
            status = null;
            yearFrom = null;
            yearTo = null;
            minRating = null;
            maxRating = null;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var exportForm = new ExportOptionsForm();
            if (exportForm.ShowDialog() == DialogResult.OK)
            {
                var booksToExport = flowBooks.Controls
                   .OfType<BookCardControl>()
                   .Select(card => card.BookData)
                   .ToList();

                if (!booksToExport.Any())
                {
                    MessageBox.Show("There are no books to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt",
                    Title = "Export Books"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (exportForm.ExportAsReadable)
                        LibraryStorage.ExportAsReadable(booksToExport, filePath);
                    else
                        LibraryStorage.ExportAsLibrary(booksToExport, filePath);

                    MessageBox.Show("Books exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";
                openFileDialog.Title = "Import Books";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        var importedBooks = LibraryStorage.ImportBooksFromFile(filePath);

                        foreach (var book in importedBooks)
                        {
                            LibraryStorage.AddBook(currentUser, book);
                        }

                        LoadBooks();

                        MessageBox.Show("Books imported successfully.", "Import Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to import books:\n{ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
