using MVP.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MVP.Models
{
    public class NewspaperModel
    {
        public static void PresentationOfNewspapers(List<Newspaper> newspaperList)
        {
            DateInitializer.NewspapersInitialization(newspaperList);
        }

        public static void SaveDataNewspaper(string fullname, List<Newspaper> newspaperList)
        {
            StreamWriter writeListNewspapers = new StreamWriter(fullname);
            foreach (var newspaper in newspaperList)
            {
                writeListNewspapers.WriteLine(newspaper.Name + " " + newspaper.Subjects);
            }
            writeListNewspapers.Close();
        }
    }
}
