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
    public partial class RefferenceBook : Form
    {
        public RefferenceBook()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void roomsButton_Click(object sender, EventArgs e)
        {
            var showRooms = new RoomForm();
            showRooms.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
