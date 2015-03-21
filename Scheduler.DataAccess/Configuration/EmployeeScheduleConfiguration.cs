using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class EmployeeScheduleConfiguration : EntityTypeConfiguration<EmployeeSchedule>
    {
        public EmployeeScheduleConfiguration()
        {
            HasKey(a => a.EmployeeScheduleId);
            Property(a => a.ScheduleDate).IsRequired();
            Property(a => a.FromTime).IsRequired();
            Property(a => a.ToTime).IsRequired();
            Property(a => a.AvailableSlots).IsRequired();
        }
    }
}