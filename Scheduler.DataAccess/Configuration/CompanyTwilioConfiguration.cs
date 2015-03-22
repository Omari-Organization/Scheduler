using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class CompanyTwilioConfiguration : EntityTypeConfiguration<CompanyTwilio>
    {
        public CompanyTwilioConfiguration()
        {
            HasKey(a => a.CompanyTwilioId);
            Property(a => a.AccountSid)
                .HasMaxLength(34)
                .IsFixedLength()
                .IsRequired();
            Property(a => a.AuthToken)
                .HasMaxLength(34)
                .IsFixedLength()
                .IsRequired();
            Property(a => a.IsActive);
        }
    }

}