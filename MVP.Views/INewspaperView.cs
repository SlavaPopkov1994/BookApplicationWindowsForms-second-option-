using MVP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views
{
    public interface INewspaperView
    {
        void NewspaperShow(List<Newspaper> newspaperList);
    }
}
