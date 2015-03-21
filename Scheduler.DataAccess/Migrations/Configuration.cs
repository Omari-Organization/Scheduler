namespace Scheduler.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Scheduler.DataAccess;
    using Scheduler.Data;
    using System.Collections.Generic;
    internal sealed class Configuration : DbMigrationsConfiguration<Scheduler.DataAccess.SchedulerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchedulerDbContext context)
        {
            var address = new Address()
            {
                City = "Duluth",
                State = "GA",
                Street = "12334 TEST ST",
                Zip = "123456-7890" 
            };
            var appointments = new List<Appointment>()
            {

            };
            var clientPhoneNumbers = new List<ClientPhoneNumber>()
            {

            };
            var clientTwilio = new ClientTwilio()
            {

            };
            var clientType = new ClientType()
            {

            };
            var customers = new List<Customer>(){};
            var employees = new List<Employee>(){};
            context.Clients.AddOrUpdate(
                    new Client
                    {
                        Address = address,
                        Appointments = appointments,
                        ClientPhoneNumbers = clientPhoneNumbers,
                        ClientTwilio = clientTwilio,
                        ClientType = clientType,
                        CreatedDate = DateTime.Now,
                        Customers = customers,
                        Employees = employees,
                        Name = new Name(),
                        TimeZone = "Central Standard Time",
                        IsActive = true
                    }
                );
        }
    }
}
