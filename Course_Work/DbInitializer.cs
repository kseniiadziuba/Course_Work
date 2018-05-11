using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Course_Work
{
    class DbInitializer : //DropCreateDatabaseAlways<DbContext>
                          CreateDatabaseIfNotExists<DbContext>
    {
        protected override void Seed(DbContext context)
        {
            context.Clients.Add(new Client(1, "Surname", "Name", "FartherName", "Address", "PHN"));
            context.Cards.Add(new Card(1, "Full", 300, 12, 30));
            context.Accounts.Add(new Account(1, 1, "10/04/2018", "09/05/2018"));
            context.Schedule.Add(new Schedule("Monday", "17:00", "18:00", "Full", 1, "Masha", "fkjb"));
            context.Rooms.Add(new Room("kdfm"));

            base.Seed(context);
        }
    }
}
