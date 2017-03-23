using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Entities
{
    public class NewspaperList
    {
        public NewspaperList()
        {
            NewspapersList = new List<Newspaper>();
        }
        public List<Newspaper> NewspapersList { get; set; }
    }
}
