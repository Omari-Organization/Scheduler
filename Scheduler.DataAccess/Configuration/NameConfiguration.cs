using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class NameConfiguration : ComplexTypeConfiguration<Name>
    {
        public NameConfiguration()
        {
            Property(a => a.BusinessName).HasColumnName("BusinessName").HasMaxLength(50);
            Property(a => a.FirstName).HasColumnName("FirstName").HasMaxLength(50);
            Property(a => a.LastName).HasColumnName("LastName").HasMaxLength(50);
            Property(a => a.MiddleName).HasColumnName("MiddleName").HasMaxLength(50);
            Property(a => a.Title).HasColumnName("Title").HasMaxLength(5);
        }
    }
}
