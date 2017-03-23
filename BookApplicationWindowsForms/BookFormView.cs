using MVP.Entities;
using MVP.Presenters;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace BookApplicationWindowsForms
{
    public partial class BookFormView : Form, IBookView
    {
        public BookPresenter _presenter;

        public BookFormView()
        {
            _presenter = new BookPresenter(this);
            InitializeComponent();
        }

        private void ListBooksBt_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.ShowBook();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void SaveBooksXML_Click(object sender, EventArgs e)
        {
            if (openFileDialogBook.ShowDialog() == DialogResult.OK)
            {
                string fullname = openFileDialogBook.FileName;
                _presenter.SaveBookXML(fullname);
            }
        }

        private void SaveBooksDB_Click(object sender, EventArgs e)
        {
            _presenter.SaveBookDB();
        }

        public void BookShow(List<Book> bookList)
        {
            ListBooksTb.Items.Add("Книги");
            foreach (var book in bookList)
            {
                ListBooksTb.Items.Add(book.Name + " " + book.Subjects);
                foreach (var author in book.Authors)
                {
                    ListBooksTb.Items.Add(author.Name + " " + author.MiddleName + " " + author.Surname);
                }
                ListBooksTb.Items.Add("-------------------------------------------------");
            }
        }

        private void ExitBt_Click(object sender, EventArgs e)
        {
            _presenter.SqlConnectionClose();
            Close();
        }

        private void BookForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            _presenter.SqlConnectionClose();
        }
    }
}
