using MVP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views
{
    public interface IJournalView
    {
        void JournalShow(List<Journal> journalList);
    }
}
