using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class CompanyPhoneNumberConfiguration : EntityTypeConfiguration<CompanyPhoneNumber>
    {
        public CompanyPhoneNumberConfiguration()
        {
            HasKey(a => a.CompanyPhoneNumberId);
            //Property(a => a.CompanyId).IsRequired();
            Property(a => a.PhoneNumber).HasMaxLength(12)
                                        .IsRequired();
            Property(a => a.IsCellPhone).IsRequired();
        }
    }
}