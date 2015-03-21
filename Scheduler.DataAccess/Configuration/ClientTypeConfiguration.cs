using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class ClientTypeConfiguration : EntityTypeConfiguration<ClientType>
    {
        public ClientTypeConfiguration()
        {
            HasKey(a => a.ClientTypeId);
            Property(a => a._ClientType).IsRequired();
        }
    }
}