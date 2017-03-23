using MVP.Entities;
using MVP.Presenters;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BookApplicationWindowsForms
{
    public partial class NewspaperFormView : Form, INewspaperView
    {
        public NewspaperPresenter _presenter;

        public NewspaperFormView()
        {
            _presenter = new NewspaperPresenter(this);
            InitializeComponent();
        }

        private void ListNewspapersBt_Click(object sender, EventArgs e)
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

        private void SaveNewspapers_Click(object sender, EventArgs e)
        {
            if (openFileDialogNewspaper.ShowDialog() == DialogResult.OK)
            {
                string fullname = openFileDialogNewspaper.FileName;
                _presenter.SaveNewspaper(fullname);
            }
        }

        public void NewspaperShow(List<Newspaper> newspaperList)
        {
            ListNewspapersTb.Items.Add("Газеты");
            foreach (var newspaper in newspaperList)
            {
                ListNewspapersTb.Items.Add(newspaper.Name + " " + newspaper.Subjects);
            }
        }
    }
}
