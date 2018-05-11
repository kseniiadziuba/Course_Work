using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int QuantityOfVisiting { get; set; }
        public int QuantityOfDays { get; set; }
        public List<Account> Accounts { get; set; }

        public Card()
        {
            Accounts= new List<Account>();
        }

        public Card(int cardId, string type, double price, int quantityOfVisiting, int quantityOfDays)
        {
            CardId = cardId;
            Type = type;
            Price = price;
            QuantityOfVisiting = quantityOfVisiting;
            QuantityOfDays = quantityOfDays;
            Accounts = new List<Account>();
        }

        public override string ToString()
        {
            return CardId.ToString();
        }
    }
}