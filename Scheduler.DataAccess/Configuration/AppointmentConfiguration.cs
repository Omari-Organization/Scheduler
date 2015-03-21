using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class AppointmentConfiguration : EntityTypeConfiguration<Appointment>
    {
        public AppointmentConfiguration()
        {
            HasKey(a => a.AppointmentId);
            Property(a => a.Description).IsRequired();
            Property(a => a.ClientId);
            Property(a => a.AppointmentTypeId).IsRequired();
            Property(a => a.CancellationDate).IsOptional();
            Property(a => a.CustomerId).IsRequired();
            Property(a => a.DateFrom).IsRequired();
            Property(a => a.DateTo).IsRequired();
            Property(a => a.EmployeeId).IsRequired();
            Property(a => a.EmployeeScheduleId).IsRequired();
            Property(a => a.IsActive).IsRequired();
        }
    }
}
