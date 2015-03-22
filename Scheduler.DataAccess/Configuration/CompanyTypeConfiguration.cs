using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Scheduler.Data;

namespace Scheduler.DataAccess.Configuration
{
    public class CompanyTypeConfiguration : EntityTypeConfiguration<CompanyType>
    {
        public CompanyTypeConfiguration()
        {
            HasKey(a => a.CompanyTypeId);
            Property(a => a.BusinessType).IsRequired();
        }
    }
}