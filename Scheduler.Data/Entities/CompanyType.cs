using Scheduler.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class CompanyType
    {
        public int CompanyTypeId { get; set; }
        public BusinessTypes BusinessType { get; set; }
    }
}
