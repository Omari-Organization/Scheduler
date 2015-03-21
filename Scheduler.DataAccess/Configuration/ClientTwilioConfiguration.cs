using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class ClientTwilioConfiguration : EntityTypeConfiguration<ClientTwilio>
    {
        public ClientTwilioConfiguration()
        {
            HasKey(a => a.ClientTwilioId);
            Property(a => a.AccountSid).IsRequired();
            Property(a => a.AuthToken).IsRequired();
            Property(a => a.IsActive);
        }
    }

}