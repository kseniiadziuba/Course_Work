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
    public partial class RemoveOneClient : Form
    {
        public int clientId;
        public RemoveOneClient()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void ClientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            clientId = Convert.ToInt32(ClientId.Text);
        }
    }
}
