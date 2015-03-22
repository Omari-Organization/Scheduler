using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(a => a.CustomerId);
            Property(a => a.Address.Street).HasColumnName("Street");
            Property(a => a.Address.City).HasColumnName("City");
            Property(a => a.Address.State).HasColumnName("State");
            Property(a => a.Address.Zip).HasColumnName("Zip");
            Property(a => a.Name.BusinessName).HasColumnName("BusinessaName");
            Property(a => a.Name.FirstName).HasColumnName("FirstName");
            Property(a => a.Name.LastName).HasColumnName("LastName");
            Property(a => a.Name.MiddleName).HasColumnName("MiddleName");
            Property(a => a.Name.Title).HasColumnName("Title");
        }
    }
}