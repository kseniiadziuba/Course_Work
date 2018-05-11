using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work.Forms
{
    public partial class ScheduleForm : Form
    {
        private DbContext db;
        public ScheduleForm()
        {
            InitializeComponent();
            CenterToScreen();
            db=new DbContext();
            db.Schedule.Load();
            db.SaveChanges();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            if (db.Schedule != null)
            {
                var table = new DataTable("Schedule");
                var id = new DataColumn("Schedule ID");
                var dayOfWeek = new DataColumn("Day Of Week");
                var startTime = new DataColumn("Start Time");
                var endTime = new DataColumn("End Time");
                var type = new DataColumn("Type");
                var room = new DataColumn("Room ID");
                var employee = new DataColumn("Employee");
                var note = new DataColumn("Note");

                table.Columns.Add(id);
                table.Columns.Add(dayOfWeek);
                table.Columns.Add(startTime);
                table.Columns.Add(endTime);
                table.Columns.Add(type);
                table.Columns.Add(room);
                table.Columns.Add(employee);
                table.Columns.Add(note);

                foreach (var schedule in db.Schedule)
                {
                    DataRow row = table.NewRow();
                    row["Schedule ID"] = schedule.ScheduleId;
                    row["Day Of Week"] = schedule.DayOfWeek;
                    row["Start Time"] = schedule.StartTime;
                    row["End Time"] = schedule.EndTime;
                    row["Type"] = schedule.Type;
                    row["Room ID"] = schedule.RoomId;
                    row["Employee"] = schedule.Employee;
                    row["Note"] = schedule.Note;
                    table.Rows.Add(row);
                }
                scheduleDataGridView.DataSource = table;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewSchedule_Click(object sender, EventArgs e)
        {
            var addSchedule = new AddNewScheduleForm();
            if (addSchedule.ShowDialog() == DialogResult.OK)
            {
                db.Schedule.Add(addSchedule.schedule);
                db.SaveChanges();
                UpdateGrid();
            }
        }

        private void RemoveSchedule_Click(object sender, EventArgs e)
        {
            var removeSchedule = new RemoveSchedule();
            if (removeSchedule.ShowDialog() == DialogResult.OK)
            {
                Schedule schedule = db.Schedule.Find(removeSchedule.scheduleIdNumber);
                try
                {
                    if (schedule != null)
                    {
                        db.Schedule.Remove(schedule);
                        db.SaveChanges();
                        UpdateGrid();
                    }
                    else
                    {
                        throw new Exception("There is no Schedule with this ID");
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
