using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class AppointmentType
    {
        public int AppointmentTypeId { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
