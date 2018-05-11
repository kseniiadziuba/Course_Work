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
    public partial class RoomForm : Form
    {
        private DbContext db;
        public RoomForm()
        {
            InitializeComponent();
            CenterToScreen();
            db=new DbContext();
            db.Rooms.Load();
            db.SaveChanges();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            if (db.Rooms != null)
            {
                var table = new DataTable("Rooms");
                var id = new DataColumn("Room ID");
                var name = new DataColumn("Name");

                table.Columns.Add(id);
                table.Columns.Add(name);

                foreach (var room in db.Rooms)
                {
                    DataRow row = table.NewRow();
                    row["Room ID"] = room.RoomId;
                    row["Name"] = room.Name;
                    table.Rows.Add(row);
                }
                roomDataGridView.DataSource = table;
            }
        }

        private void addNewRoom_Click(object sender, EventArgs e)
        {
            var addNewRoomForm = new AddNewRoomForm();
            if (addNewRoomForm.ShowDialog() == DialogResult.OK)
            {
                db.Rooms.Add(addNewRoomForm.room);
                db.SaveChanges();
                UpdateGrid();
            }
        }

        private void removeRoom_Click(object sender, EventArgs e)
        {
            var removeRoomForm = new RemoveRoomForm();
            if (removeRoomForm.ShowDialog() == DialogResult.OK)
            {
                Room room = db.Rooms.Find(removeRoomForm.roomId);
                try
                {
                    if (room != null)
                    {
                        db.Rooms.Remove(room);
                        db.SaveChanges();
                        UpdateGrid();
                    }
                    else
                    {
                        throw new Exception("There is no room with this ID");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
