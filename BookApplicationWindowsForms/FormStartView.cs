using MVP.Entities;
using MVP.Presenters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BookApplicationWindowsForms
{
    public partial class FormStartView : Form
    {
        public FormStartView()
        {
            InitializeComponent();
        }

        private void ListBooks_Click(object sender, EventArgs e)
        {
            BookFormView view = new BookFormView();
            view.Show();
        }

        private void ListNewspapersBt_Click(object sender, EventArgs e)
        {
            NewspaperFormView view = new NewspaperFormView();
            view.Show();
        }

        private void ListJournalsBt_Click(object sender, EventArgs e)
        {
            JournalFormView view = new JournalFormView();
            view.Show();
        }
    }
}
