using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FartherName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<Account> Accounts { get; set; }

        public Client()
        {
            Accounts = new List<Account>();
        }

        public Client(int clientId, string surname, string name, string fartherName, string address, string phoneNumber)
        {
            ClientId = clientId;
            Surname = surname;
            Name = name;
            FartherName = fartherName;
            Address = address;
            PhoneNumber = phoneNumber;
            Accounts = new List<Account>();
        }
    }
}
