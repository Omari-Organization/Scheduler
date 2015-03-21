using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class ClientPhoneNumberConfiguration : EntityTypeConfiguration<ClientPhoneNumber>
    {
        public ClientPhoneNumberConfiguration()
        {
            HasKey(a => a.ClientPhoneNumberId);
            Property(a => a.ClientId).IsRequired();
            Property(a => a.PhoneNumber).HasMaxLength(12)
                                        .IsRequired();
            Property(a => a.IsCellPhone).IsRequired();
        }
    }
}