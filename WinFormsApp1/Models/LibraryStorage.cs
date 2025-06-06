using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Models
{
    public static class LibraryStorage
    {
        public static void AddBook(string username, Book book)
        {
            string path = UserStorage.GetLibraryFilePath(username);

            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(book.ToString());
            }
        }

        public static void UpdateBook(string username, Book oldBook, Book newBook)
        {
            string path = UserStorage.GetLibraryFilePath(username);
            if (!File.Exists(path)) return;

            var lines = File.ReadAllLines(path).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var book = Book.FromString(lines[i]);

                if (IsSameBook(book, oldBook))
                {
                    lines[i] = newBook.ToString();
                    break;
                }
            }

            File.WriteAllLines(path, lines);
        }
        private static bool IsSameBook(Book a, Book b)
        {
            return a.Id == b.Id;
        }
        public static void DeleteBook(string username, Book bookToDelete)
        {
            string path = UserStorage.GetLibraryFilePath(username);
            if (!File.Exists(path)) return;

            var lines = File.ReadAllLines(path).ToList();
            lines.RemoveAll(line =>
            {
                var book = Book.FromString(line);
                return IsSameBook(book, bookToDelete);
            });

            File.WriteAllLines(path, lines);
        }

        public static List<Book> LoadBooks(string username)
        {
            string path = UserStorage.GetLibraryFilePath(username);
            var books = new List<Book>();

            if (!File.Exists(path)) return books;

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    books.Add(Book.FromString(line));
                }
            }

            return books;
        }

        public static List<Book> SearchBooks(
            string username,
            string title = "",
            string author = "",
            Genre? genre = null,
            Language? language = null,
            BookStatus? status = null,
            int? yearFrom = null,
            int? yearTo = null,
            double? minRating = null,
            double? maxRating = null)
        {
            var books = LoadBooks(username);

            yearFrom ??= int.MinValue;
            yearTo ??= int.MaxValue;
            minRating ??= 0.0;
            maxRating ??= 10.0;

            return books.Where(book =>
                (string.IsNullOrWhiteSpace(title) || book.Title.Contains(title, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(author) || book.Author.Contains(author, StringComparison.OrdinalIgnoreCase)) &&
                (!genre.HasValue || book.Genre == genre.Value) &&
                (!language.HasValue || book.Language == language.Value) &&
                (!status.HasValue || book.Status == status.Value) &&
                (book.Year >= yearFrom.Value) &&
                (book.Year <= yearTo.Value) &&
                (book.Rating >= minRating.Value) &&
                (book.Rating <= maxRating.Value)
            ).ToList();
        }

        public static List<Book> ImportBooksFromFile(string filePath)
        {
            var books = new List<Book>();

            foreach (var line in File.ReadAllLines(filePath))
            {
                try
                {
                    var parts = line.Split('|');
                    if (parts.Length != 11)
                        throw new FormatException("Incorrect number of fields.");

                    books.Add(Book.FromString(line));
                }
                catch
                {
                    throw new Exception("Invalid format in file. Please ensure it matches the export structure.");
                }
            }

            return books;
        }

        public static void ExportAsReadable(List<Book> books, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    sw.WriteLine($"Title: {book.Title}");
                    sw.WriteLine($"Author: {book.Author}");
                    sw.WriteLine($"Genre: {book.Genre}");
                    sw.WriteLine($"Language: {book.Language}");
                    sw.WriteLine($"Year: {book.Year}");
                    sw.WriteLine($"Rating: {book.Rating}/10");
                    sw.WriteLine($"Status: {book.Status}");
                    sw.WriteLine($"Description: {book.Description}");
                    sw.WriteLine($"Note: {book.Note}");
                    sw.WriteLine(new string('-', 40));
                }
            }
        }

        public static void ExportAsLibrary(List<Book> books, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    sw.WriteLine(book.ToString());
                }
            }
        }
    }
}
