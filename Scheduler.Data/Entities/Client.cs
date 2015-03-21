using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class Client
    {
        public Client() {
            Address = new Address();
            Name = new Name();
        }
        public int ClientId { get; set; }
        public bool IsActive { get; set; }
        public int ClientTypeId { get; set; }
        public virtual ClientType ClientType { get; set; }
        public Address Address { get; set; }
        public Name Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<ClientPhoneNumber> ClientPhoneNumbers { get; set; }
        public int ClientTwilioId { get; set; }
        public virtual ClientTwilio ClientTwilio { get; set; }
        public string TimeZone { get; set; }
    }
}
