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
    public partial class AddNewScheduleForm : Form
    {
        public Schedule schedule;
        public AddNewScheduleForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            schedule = new Schedule(dayOfWeekTextBox.Text, startTimeTextBox.Text, endTimeTextBox.Text, typeTextBox.Text, Convert.ToInt32(roomTextBox.Text), employeeTextBox.Text, noteTextBox.Text);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
