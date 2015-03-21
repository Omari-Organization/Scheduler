using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class ClientTwilio
    {
        public int ClientTwilioId { get; set; }
        public string AuthToken { get; set; }
        public string AccountSid { get; set; }
        public bool IsActive { get; set; }
    }
}
