using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Entities
{
    public class Newspaper : IPolygraphy
    {
        public string Name { get; set; }
        public string Subjects { get; set; }
    }
}
