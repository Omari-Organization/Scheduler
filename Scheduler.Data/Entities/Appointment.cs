using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string Description { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int AppointmentTypeId { get; set; }
        public virtual AppointmentType AppointmentType { get; set; }
        public int ClientId { get; set; }   
        public virtual Client Client { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee {get; set;}
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public bool IsActive { get; set; }
        public DateTime CancellationDate { get; set; }
        public int EmployeeScheduleId { get; set; }
        public virtual EmployeeSchedule EmployeeSchedule { get; set; }
    }
}
