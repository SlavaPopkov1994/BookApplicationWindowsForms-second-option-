using System;
using System.Collections.Generic;
using System.Text;

namespace MVP.Entities
{
    public class JournalList
    {
        public JournalList()
        {
            JournalsList = new List<Journal>();
        }
        public List<Journal> JournalsList { get; set; }
    }
}
