using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    public class VisitingCalculation
    {
        public int VisitingId { get; set; }
        public Account Account { get; set; }
        public int CardId { get; set; }
        public Schedule Schedule { get; set; }
        public int ScheduleId { get; set; }

        public VisitingCalculation()
        {

        }

        public VisitingCalculation(int accountId, int scheduleId)
        {
            CardId = accountId;
            ScheduleId = scheduleId;
        }
    }
}
