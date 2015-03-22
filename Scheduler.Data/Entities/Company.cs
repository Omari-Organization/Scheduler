using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scheduler.Data
{
    public class Company
    {
        public Company() {
            Address = new Address();
            Name = new Name();
        }
        public int CompanyId { get; set; }
        public bool IsActive { get; set; }
        public int CompanyTypeId { get; set; }
        public virtual CompanyType CompanyType { get; set; }
        public Address Address { get; set; }
        public Name Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<CompanyPhoneNumber> CompanyPhoneNumbers { get; set; }
        public int CompanyTwilioId { get; set; }
        public virtual CompanyTwilio CompanyTwilio { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
    }
}
