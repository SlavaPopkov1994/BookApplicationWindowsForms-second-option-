using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Entities
{
    public class Book : IPolygraphy
    {
        public Book()
        {
            Authors = new List<Author>();
        }
        public List<Author> Authors { get; set; }
        public string Name { get; set; }
        public string Subjects { get; set; }
    }
}
