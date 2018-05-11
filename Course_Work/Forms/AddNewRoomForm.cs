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
    public partial class AddNewRoomForm : Form
    {
        public Room room;
        public AddNewRoomForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            room = new Room(roomNameTextBox.Text);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
