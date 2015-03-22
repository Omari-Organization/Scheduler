using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class CompanyPhoneNumber
    {
        public int CompanyPhoneNumberId { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsCellPhone { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
