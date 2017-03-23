using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Entities
{
    public class BookList
    {
        public BookList()
        {
            BooksList = new List<Book>();
        }
        public List<Book> BooksList { get; set; }
    }
}
