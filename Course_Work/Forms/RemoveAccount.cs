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
    public partial class RemoveAccount : Form
    {
        public int accountId;
        public RemoveAccount()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            accountId = Convert.ToInt32(AccountId.Text);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
