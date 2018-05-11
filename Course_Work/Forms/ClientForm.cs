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

namespace Course_Work
{
    public partial class ClientForm : Form
    {
        DbContext db;

        public ClientForm()
        {
            InitializeComponent();
            CenterToScreen();
            db = new DbContext();
            db.Clients.Load();

            db.SaveChanges();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            if (db.Clients != null)
            {
                var table = new DataTable("Clients");
                var id = new DataColumn("Client ID");
                var name = new DataColumn("Name");
                var surname = new DataColumn("Surname");
                var fartherName = new DataColumn("Farther Name");
                var address = new DataColumn("Address");
                var phoneNumber = new DataColumn("Phone Number");

                table.Columns.Add(id);
                table.Columns.Add(name);
                table.Columns.Add(surname);
                table.Columns.Add(fartherName);
                table.Columns.Add(address);
                table.Columns.Add(phoneNumber);

                foreach (var client in db.Clients)
                {
                    DataRow row = table.NewRow();
                    row["Client ID"] = client.ClientId;
                    row["Name"] = client.Name;
                    row["Surname"] = client.Surname;
                    row["Farther Name"] = client.FartherName;
                    row["Address"] = client.Address;
                    row["Phone Number"] = client.FartherName;
                    table.Rows.Add(row);
                }
                clientsTableView.DataSource = table;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoveAllClientsClick(object sender, EventArgs e)
        {
            DeleteAllClients();
        }

        private void DeleteAllClients()
        {
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Clients]");
            db.SaveChanges();
            UpdateGrid();
        }

        private void CloseAppClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddNewClientClick(object sender, EventArgs e)
        {
            var addNewClientDialog = new AddNewClientForm();
            if (addNewClientDialog.ShowDialog() == DialogResult.OK)
            {
                db.Clients.Add(addNewClientDialog.client);
                db.SaveChanges();
                UpdateGrid();
            }
        }

        private void RemoveClientClick(object sender, EventArgs e)
        {
            var removeOneClient = new RemoveOneClient();
            if (removeOneClient.ShowDialog() == DialogResult.OK)
            {
                Client removeClient = db.Clients.Find(removeOneClient.clientId);
                try
                {
                    if (removeClient != null)
                    {
                        db.Clients.Remove(removeClient);
                        db.SaveChanges();
                        UpdateGrid();
                    }
                    else
                    {
                        throw new Exception("There is no Client with this ID");
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void BackToMainMenu(object sender, EventArgs e)
        {
            var mainMenuForm = new MainForm();
            mainMenuForm.ShowDialog();
        }

        private void clientsTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}