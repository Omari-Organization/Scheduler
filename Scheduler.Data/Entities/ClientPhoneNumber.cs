using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class ClientPhoneNumber
    {
        public int ClientPhoneNumberId { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsCellPhone { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
