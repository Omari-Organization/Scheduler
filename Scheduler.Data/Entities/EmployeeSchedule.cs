using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class EmployeeSchedule
    {
        public int EmployeeScheduleId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public int AvailableSlots { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
