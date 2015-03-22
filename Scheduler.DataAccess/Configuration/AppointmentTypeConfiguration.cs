using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class AppointmentTypeConfiguration : EntityTypeConfiguration<AppointmentType>
    {
        public AppointmentTypeConfiguration()
        {
            HasKey(a => a.AppointmentTypeId);
            Property(a => a.CompanyId).IsRequired();
            Property(a => a.Description).HasMaxLength(100).IsRequired();
        }
    }
  
}
