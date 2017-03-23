using MVP.Entities;
using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;

namespace MVP.Presenters
{
    public class JournalPresenter
    {
        private JournalList _model;
        private IJournalView _view;

        public JournalPresenter(IJournalView view)
        {
            _model = new JournalList();
            _view = view;
        }

        public void ShowJournal()
        {
            JournalModel.PresentationOfJournals(_model.JournalsList);
            _view.JournalShow(_model.JournalsList);
        }

        public void SaveJournal(string fullname)
        {
            JournalModel.SaveDataJournal(fullname, _model.JournalsList);
        }
    }
}
