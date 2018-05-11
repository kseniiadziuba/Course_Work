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
    public partial class CardForm : Form
    {
        private DbContext db;
        public CardForm()
        {
            InitializeComponent();
            CenterToScreen();
            db = new DbContext();
            db.Cards.Load();

            db.SaveChanges();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            if (db.Cards != null)
            {
                var table = new DataTable("Cards");
                var id = new DataColumn("Card ID");
                var type = new DataColumn("Type");
                var price = new DataColumn("Price");
                var quantityOfVisiting = new DataColumn("Quantity Of Visiting");
                var quantityOfDays = new DataColumn("Quantity Of Days");

                table.Columns.Add(id);
                table.Columns.Add(type);
                table.Columns.Add(price);
                table.Columns.Add(quantityOfVisiting);
                table.Columns.Add(quantityOfDays);

                foreach (var card in db.Cards)
                {
                    DataRow row = table.NewRow();
                    row["Card ID"] = card.CardId;
                    row["Type"] = card.Type;
                    row["Price"] = card.Price;
                    row["Quantity Of Visiting"] = card.QuantityOfVisiting;
                    row["Quantity Of Days"] = card.QuantityOfDays;
                    table.Rows.Add(row);
                }
                cardsDataGridView.DataSource = table;
            }
        }

        private void AddNewCard_Click(object sender, EventArgs e)
        {
            var addNewCard = new AddNewCardForm();
            if (addNewCard.ShowDialog() == DialogResult.OK)
            {
                db.Cards.Add(addNewCard.card);
                db.SaveChanges();
                UpdateGrid();
            }
        }

        private void RemoveCard_Click(object sender, EventArgs e)
        {
            var removeCardForm = new RemoveCard();
            if (removeCardForm.ShowDialog() == DialogResult.OK)
            {
                Card removeCard = db.Cards.Find(removeCardForm.cardID);
                try
                {
                    if (removeCard != null)
                    {
                        db.Cards.Remove(removeCard);
                        db.SaveChanges();
                        UpdateGrid();
                    }
                    else
                    {
                        throw new Exception("There is no Card with this ID");
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            var mainMenuForm = new MainForm();
            mainMenuForm.ShowDialog();
        }
    }
}