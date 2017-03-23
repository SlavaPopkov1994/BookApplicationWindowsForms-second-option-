using MVP.Entities;
using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;

namespace MVP.Presenters
{
    public class BookPresenter
    {
        private BookList _model;
        private IBookView _view;

        public BookPresenter(IBookView view)
        {
            _model = new BookList();
            _view = view;
        }

        public void ShowBook()
        {
            BookModel.PresentationOfBooks(_model.BooksList);
            _view.BookShow(_model.BooksList);
        }

        public void SaveBookXML(string fullname)
        {
            BookModel.SaveDataBookXML(fullname, _model.BooksList);
        }

        public void SaveBookDB()
        {
            BookModel.SaveDataBookDB(_model.BooksList);
        }

        public void SqlConnectionClose()
        {
            BookModel.SqlConnectionClose();
        }
    }
}
