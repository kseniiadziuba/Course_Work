using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public List<Schedule> Schedules { get; set; }

        public Room()
        {
             Schedules = new List<Schedule>();
        }

        public Room(string name)
        {
            Name = name;
            Schedules = new List<Schedule>();
        }
    }
}
