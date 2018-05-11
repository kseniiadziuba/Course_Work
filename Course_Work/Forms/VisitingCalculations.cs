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
    public partial class VisitingCalculations : Form
    {
        private DbContext db;
        public VisitingCalculations()
        {
            InitializeComponent();
            CenterToParent();
            db=new DbContext();
            db.VisitingCalculations.Load();
            db.SaveChanges();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            if (db.VisitingCalculations != null)
            {
                var table = new DataTable("Visiting Calculations");
                var visitingId = new DataColumn("Visiting ID");
                var accountId = new DataColumn("Card ID");
                var surname = new DataColumn("Surname");
                var scheduleId = new DataColumn("Schedule ID");
                var date = new DataColumn("Date");

                table.Columns.Add(visitingId);
                table.Columns.Add(accountId);
                table.Columns.Add(surname);
                table.Columns.Add(scheduleId);
                table.Columns.Add(date);

                foreach (var visitings in db.VisitingCalculations)
                {
                    DataRow row = table.NewRow();
                    row["Visiting ID"] = visitings.VisitingId;
                    row["Card ID"] = visitings.CardId;
                    row["Surname"] = visitings.Account.Client.Surname;
                    row["Schedule ID"] = visitings.ScheduleId;
                    table.Rows.Add(row);
                }
                visitingCalculationsDataGridView.DataSource = table;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
