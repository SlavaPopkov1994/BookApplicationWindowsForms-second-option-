using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Entities
{
    public class Journal : IPolygraphy
    {
        public string Name { get; set; }
        public string Subjects { get; set; }
        public string Cover { get; set; }
    }
}
