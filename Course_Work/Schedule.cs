using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public string DayOfWeek { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Type { get; set; }
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public string Employee { get; set; }
        public string Note { get; set; }
        public List<VisitingCalculation> VisitingCalculations { get; set; }
        public Schedule()
        {
            VisitingCalculations = new List<VisitingCalculation>();
        }

        public Schedule(string dayOfWeek, string startTime, string endTime, string type, int roomId, string employee,
            string note)
        {
            DayOfWeek = dayOfWeek;
            StartTime = Convert.ToDateTime(startTime);
            EndTime = Convert.ToDateTime(endTime);
            Type = type;
            RoomId = roomId;
            Employee = employee;
            Note = note;
            VisitingCalculations=new List<VisitingCalculation>();
        }
    }
}