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
using Course_Work.Forms;

namespace Course_Work
{
    public partial class AccountForm : Form
    {
        private DbContext db;
        private int selectedCardId;

        public AccountForm()
        {
            InitializeComponent();
            CenterToScreen();

            db = new DbContext();
            db.Accounts.Load();
            db.SaveChanges();

            List<Card> cards = new List<Card>();
            cards = db.Cards.ToList();
            cardIdComboBox.DataSource = cards;

            //UpdateGrid();
        }

        /*private void UpdateGrid()
        {
            if (db.Accounts != null)
            {
                var table = new DataTable("Accounts");
                var id = new DataColumn("Account ID");
                var clientId = new DataColumn("Client ID");
                var cardId = new DataColumn("Card ID");
                var beginDate = new DataColumn("Begin Date");
                var endDate = new DataColumn("End Date");

                table.Columns.Add(id);
                table.Columns.Add(clientId);
                table.Columns.Add(cardId);
                table.Columns.Add(beginDate);
                table.Columns.Add(endDate);

                foreach (var account in db.Accounts)
                {
                    DataRow row = table.NewRow();
                    row["Account ID"] = account.AccountId;
                    row["Client ID"] = account.ClientId;
                    row["Card ID"] = account.CardId;
                    row["Begin Date"] = account.Begin;
                    row["End Date"] = account.End;
                    table.Rows.Add(row);
                }

                accountDataGridView.DataSource = table;
            }
        }*/

        private void AddNewAccount_Click(object sender, EventArgs e)
        {
            var addNewAccount = new AddNewAccountForm();
            if (addNewAccount.ShowDialog() == DialogResult.OK)
            {
                db.Accounts.Add(addNewAccount.account);
                db.SaveChanges();
                //UpdateGrid();
            }
        }

        private void RemoveAccount_Click(object sender, EventArgs e)
        {
            var removeAccountForm = new RemoveAccount();
            if (removeAccountForm.ShowDialog() == DialogResult.OK)
            {
                Account removeAccount = db.Accounts.Find(removeAccountForm.accountId);
                try
                {
                    if (removeAccount != null)
                    {
                        db.Accounts.Remove(removeAccount);
                        db.SaveChanges();
                        // UpdateGrid();
                    }
                }
                catch
                {
                    MessageBox.Show("There is no Account with this ID!");
                }
            }
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainForm();
            mainMenu.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cardIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Card selectedCard = (Card)cardIdComboBox.SelectedItem;
            selectedCardId = selectedCard.CardId;

            var selectedClientId = (from card in db.Accounts
                                    where card.CardId == selectedCardId
                                    select card.ClientId).SingleOrDefault();
            clientIdTextBox.Text = selectedClientId.ToString();

            var selectedAccountType = (from account in db.Cards
                                       where account.CardId == selectedCardId
                                       select account.Type).SingleOrDefault();
            accountTypeTextBox.Text = selectedAccountType;

            var price = (from card in db.Cards
                         where card.CardId == selectedCardId
                         select card.Price).SingleOrDefault();
            priceTextBox.Text = price.ToString();

            var quantityOfVisiting = (from card in db.Cards
                                      where card.CardId == selectedCardId
                                      select card.QuantityOfVisiting).SingleOrDefault();
            quantityOfVisitingTextBox.Text = quantityOfVisiting.ToString();

            var quantityOfDays = (from card in db.Cards
                                  where card.CardId == selectedCardId
                                  select card.QuantityOfDays).SingleOrDefault();
            quantityOfDaysTextBox.Text = quantityOfDays.ToString();

            var beginDate = (from card in db.Accounts
                             where card.CardId == selectedCardId
                             select card.Begin).SingleOrDefault();
            beginDateTextBox.Text = beginDate.ToString();

            var endDate = (from card in db.Accounts
                           where card.CardId == selectedCardId
                           select card.End).SingleOrDefault();
            endDateTextBox.Text = endDate.ToString();
        }
    }
}