using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasKey(a => a.EmployeeId);
            Property(a => a.FirstName).HasMaxLength(50);
            Property(a => a.LastName).HasMaxLength(50);
            Property(a => a.MiddleName).HasMaxLength(50);
           
            //One to many
            HasMany(a => a.Appointments)
                .WithRequired(a => a.Employee)
                .HasForeignKey(a => a.EmployeeId);
        }
    }
}