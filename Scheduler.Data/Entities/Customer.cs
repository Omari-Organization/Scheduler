using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class Customer
    {
        public Customer()
        {
            Address = new Address();
            Name = new Name();
            Companies = new List<Company>();
            Appointments = new List<Appointment>();
        }
        public int CustomerId { get; set; }
        public Name Name { get; set; }
        public string EmailAddress { get; set; }
        public Address Address { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
