using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class Employee
    {
        public Employee()
        {
            EmployeeSchedules = new List<EmployeeSchedule>();
            Appointments = new List<Appointment>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<EmployeeSchedule> EmployeeSchedules { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
