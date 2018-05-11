using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Course_Work.Forms;

namespace Course_Work
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            var showClients = new ClientForm();
            showClients.ShowDialog();
        }

        private void Cards_Click(object sender, EventArgs e)
        {
            var showCards = new CardForm();
            showCards.ShowDialog();
        }

        private void Accounts_Click(object sender, EventArgs e)
        {
            var showAccounts = new AccountForm();
            showAccounts.ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Schedule_Click(object sender, EventArgs e)
        {
            var showSchedule = new ScheduleForm();
            showSchedule.ShowDialog();
        }

        private void refferenceBookButton_Click(object sender, EventArgs e)
        {
            var refferenceBook = new RefferenceBook();
            refferenceBook.ShowDialog();
        }

        private void visitingCalculations_Click(object sender, EventArgs e)
        {
            var visitingCalculationsForm = new VisitingCalculations();
            visitingCalculationsForm.ShowDialog();
        }
    }
}