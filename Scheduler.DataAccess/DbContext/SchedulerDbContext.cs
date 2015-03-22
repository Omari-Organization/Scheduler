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
            : base("Name=SchedulerDb") { 
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientPhoneNumber> ClientPhoneNumbers { get; set; }
        public DbSet<ClientTwilio> ClientTwilios { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSchedule> EmployeeSchedules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new AppointmentConfiguration());
            modelBuilder.Configurations.Add(new AppointmentTypeConfiguration());
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new ClientPhoneNumberConfiguration());
            modelBuilder.Configurations.Add(new ClientTwilioConfiguration());
            modelBuilder.Configurations.Add(new ClientTypeConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new EmployeeScheduleConfiguration());
            modelBuilder.Configurations.Add(new NameConfiguration());
        }
    }
}
