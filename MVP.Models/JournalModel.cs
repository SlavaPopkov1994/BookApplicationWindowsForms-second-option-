using MVP.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MVP.Models
{
    public class JournalModel
    {
        public static void PresentationOfJournals(List<Journal> journalList)
        {
            DateInitializer.JournalsInitialization(journalList);
        }

        public static void SaveDataJournal(string fullname, List<Journal> journalList)
        {
            StreamWriter writeListJournals = new StreamWriter(fullname);
            foreach (var journal in journalList)
            {
                writeListJournals.WriteLine(journal.Name + " " + journal.Subjects + " " + journal.Cover);
            }
            writeListJournals.Close();
        }
    }
}
