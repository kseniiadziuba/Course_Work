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
    public partial class RemoveCard : Form
    {
        public int cardID;
        public RemoveCard()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            cardID = Convert.ToInt32(CardIdTextBox.Text);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
