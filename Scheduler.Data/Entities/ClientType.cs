using Scheduler.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class ClientType
    {
        public int ClientTypeId { get; set; }
        public ClientTypes _ClientType { get; set; }
    }
}
