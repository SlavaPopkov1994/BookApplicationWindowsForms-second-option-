using MVP.Entities;
using MVP.Presenters;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookApplicationWindowsForms
{
    public partial class JournalFormView : Form, IJournalView
    {
        public JournalPresenter _presenter; 

        public JournalFormView()
        {
            _presenter = new JournalPresenter(this);
            InitializeComponent();
        }

        private void ListJournalsBt_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.ShowJournal();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void SaveJournals_Click(object sender, EventArgs e)
        {
            if (openFileDialogJournal.ShowDialog() == DialogResult.OK)
            {
                string fullname = openFileDialogJournal.FileName;
                _presenter.SaveJournal(fullname);
            }
        }

        public void JournalShow(List<Journal> journalList)
        {
            ListJournalsTb.Items.Add("Журналы");
            foreach (var journal in journalList)
            {
                ListJournalsTb.Items.Add(journal.Name + " " + journal.Subjects + " " + journal.Cover);
            }
        }
    }
}
