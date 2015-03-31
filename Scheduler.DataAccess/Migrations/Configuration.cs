namespace Scheduler.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Scheduler.DataAccess;
    using Scheduler.Data;
    using System.Collections.Generic;
    using Scheduler.Data.Enums;
    internal sealed class Configuration : DbMigrationsConfiguration<Scheduler.DataAccess.SchedulerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchedulerDbContext context)
        {
        //    var address = new Address()
        //    {
        //        City = "Duluth",
        //        State = "GA",
        //        Street = "12334 TEST ST",
        //        Zip = "123456-7890" 
        //    };
        //    var appointments = new List<Appointment>()
        //    {

        //    };
        //    var clientPhoneNumbers = new List<CompanyPhoneNumber>()
        //    {

        //    };
        //    var clientTwilio = new CompanyTwilio()
        //    {

        //    };
        //    var clientType = new CompanyType()
        //    {

        //    };
        //    var customers = new List<Customer>(){};
        //    var employees = new List<Employee>(){};
        //    context.Companies.AddOrUpdate(
        //            new Company
        //            {
        //                Address = address,
        //                Appointments = appointments,
        //                CompanyPhoneNumbers = clientPhoneNumbers,
        //                CompanyTwilio = clientTwilio,
        //                CompanyType = clientType,
        //                CreatedDate = DateTime.Now,
        //                Customers = customers,
        //                Employees = employees,
        //                Name = new Name(),
        //                TimeZone = "Eastern Standard Time",
        //                IsActive = true
        //            }
        //        );
        }
    }
}
