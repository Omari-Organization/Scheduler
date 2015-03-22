using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            HasKey(a => a.CompanyId);
            Property(a => a.IsActive);
            Property(a => a.CreatedDate).IsRequired();
            Property(a => a.Address.Street).HasColumnName("Street");
            Property(a => a.Address.City).HasColumnName("City");
            Property(a => a.Address.State).HasColumnName("State");
            Property(a => a.Address.Zip).HasColumnName("Zip");
            Property(a => a.Name.BusinessName).HasColumnName("BusinessaName");
            Property(a => a.Name.FirstName).HasColumnName("FirstName");
            Property(a => a.Name.LastName).HasColumnName("LastName");
            Property(a => a.Name.MiddleName).HasColumnName("MiddleName");
            Property(a => a.Name.Title).HasColumnName("Title");
            //One to many
            HasMany(a => a.Appointments)
                .WithRequired(a => a.Company)
                .HasForeignKey(a => a.CompanyId);

            HasMany(a => a.CompanyPhoneNumbers)
                .WithRequired(a => a.Company)
                .HasForeignKey(a => a.CompanyId);

            HasMany(a => a.Employees)
                .WithRequired(a => a.Company)
                .HasForeignKey(a => a.CompanyId);

            //Many to many
            HasMany(a => a.Customers)
                .WithMany(a => a.Companies);
        }
    }
}