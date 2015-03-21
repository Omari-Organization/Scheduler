using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class AddressConfiguration : ComplexTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            Property(a => a.Street).HasColumnName("Street").HasMaxLength(50);
            Property(a => a.City).HasColumnName("City").HasMaxLength(50);
            Property(a => a.State).HasColumnName("State").HasMaxLength(2);
            Property(a => a.Zip).HasColumnName("Zip").HasMaxLength(10);
        }
    }
}
