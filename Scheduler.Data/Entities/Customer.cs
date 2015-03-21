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
        }
        public int CustomerId { get; set; }
        public Name Name { get; set; }
        public string EmailAddress { get; set; }
        public Address Address { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
