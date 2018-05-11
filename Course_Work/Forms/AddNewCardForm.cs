using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class AddNewCardForm : Form
    {
        public Card card;
        public AddNewCardForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            card = new Card(1, cardTypeTextBox.Text, Convert.ToDouble(cardPriceTextBox.Text), Convert.ToInt32(quantityOfVisitingTextBox.Text), Convert.ToInt32(quantityOfDaysTextBox.Text));
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
