using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work.Forms
{
    public partial class AddNewAccountForm : Form
    {
        public Account account;
        public AddNewAccountForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            account = new Account(Convert.ToInt32(ClientIdTextBox.Text), Convert.ToInt32(CardIdTextBox.Text), BeginDateTextBox.Text, EndDateTextBox.Text);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
