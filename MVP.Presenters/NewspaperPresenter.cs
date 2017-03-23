using MVP.Entities;
using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;

namespace MVP.Presenters
{
    public class NewspaperPresenter
    {
        private NewspaperList _model;
        private INewspaperView _view;

        public NewspaperPresenter(INewspaperView view)
        {
            _model = new NewspaperList();
            _view = view;
        }

        public void ShowJournal()
        {
            NewspaperModel.PresentationOfNewspapers(_model.NewspapersList);
            _view.NewspaperShow(_model.NewspapersList);
        }

        public void SaveNewspaper(string fullname)
        {
            NewspaperModel.SaveDataNewspaper(fullname, _model.NewspapersList);
        }
    }
}
