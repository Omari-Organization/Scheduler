using Scheduler.Data;
using Scheduler.DataAccess.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Scheduler.DataAccess
{

    public class SchedulerDbContext : DbContext
    {
        public SchedulerDbContext()
            : base("Name=SchedulerDatabase") { 
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyPhoneNumber> CompanyPhoneNumbers { get; set; }
        public DbSet<CompanyTwilio> CompanyTwilios { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSchedule> EmployeeSchedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new AppointmentConfiguration());
            modelBuilder.Configurations.Add(new AppointmentTypeConfiguration());
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new CompanyPhoneNumberConfiguration());
            modelBuilder.Configurations.Add(new CompanyTwilioConfiguration());
            modelBuilder.Configurations.Add(new CompanyTypeConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new EmployeeScheduleConfiguration());
            modelBuilder.Configurations.Add(new NameConfiguration());
        }
    }
}
