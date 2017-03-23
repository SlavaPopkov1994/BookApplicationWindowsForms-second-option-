using MVP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Views
{
    public interface IBookView
    {
        void BookShow(List<Book> bookList);
    }
}
