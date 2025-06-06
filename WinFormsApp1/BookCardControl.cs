using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeLibrary.Models;

namespace HomeLibrary
{
    public partial class BookCardControl: UserControl
    {
        public Book BookData { get; private set; }

        public event EventHandler BookClicked;

        public BookCardControl(Book book)
        {
            InitializeComponent();
            BookData = book;

            lblTitle.Text = book.Title;
            lblAuthor.Text = book.Author;

            if (!string.IsNullOrEmpty(book.ImagePath) && File.Exists(book.ImagePath))
                pictureBoxCover.Image = Image.FromFile(book.ImagePath);
            else
                pictureBoxCover.Image = Image.FromFile("default_book.jpg");

            AttachClickEventRecursively(this);
            Cursor = Cursors.Hand;

        }

        private void AttachClickEventRecursively(Control control)
        {
            control.Click += BookCard_Click;

            foreach (Control child in control.Controls)
            {
                AttachClickEventRecursively(child);
            }
        }

        private void BookCard_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
