using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    public class Account
    {
        public int AccountId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public Card Card { get; set; }
        public int CardId { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public List<VisitingCalculation> VisitingCalculations { get; set; }

        public Account()
        {
            VisitingCalculations = new List<VisitingCalculation>();
        }

        public Account(int clientId, int cardId, string begin, string end)
        {
            ClientId = clientId;
            CardId = cardId;
            Begin = Convert.ToDateTime(begin);
            End = Convert.ToDateTime(end);
            VisitingCalculations = new List<VisitingCalculation>();
        }
    }
}