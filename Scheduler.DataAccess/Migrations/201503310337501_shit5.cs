namespace Scheduler.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shit5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        AppointmentTypeId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CancellationDate = c.DateTime(),
                        EmployeeScheduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: false)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.AppointmentTypes", t => t.AppointmentTypeId, cascadeDelete: false)
                .ForeignKey("dbo.EmployeeSchedules", t => t.EmployeeScheduleId, cascadeDelete: false)
                .Index(t => t.AppointmentTypeId)
                .Index(t => t.CompanyId)
                .Index(t => t.EmployeeId)
                .Index(t => t.CustomerId)
                .Index(t => t.EmployeeScheduleId);
            
            CreateTable(
                "dbo.AppointmentTypes",
                c => new
                    {
                        AppointmentTypeId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentTypeId)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        CompanyTypeId = c.Int(nullable: false),
                        Street = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        State = c.String(maxLength: 2),
                        Zip = c.String(maxLength: 10),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        Title = c.String(maxLength: 5),
                        BusinessaName = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        CompanyTwilioId = c.Int(nullable: false),
                        TimeZone = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId)
                .ForeignKey("dbo.CompanyTwilios", t => t.CompanyTwilioId, cascadeDelete: false)
                .ForeignKey("dbo.CompanyTypes", t => t.CompanyTypeId, cascadeDelete: false)
                .Index(t => t.CompanyTypeId)
                .Index(t => t.CompanyTwilioId);
            
            CreateTable(
                "dbo.CompanyPhoneNumbers",
                c => new
                    {
                        CompanyPhoneNumberId = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(nullable: false, maxLength: 12),
                        IsCellPhone = c.Boolean(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyPhoneNumberId)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.CompanyTwilios",
                c => new
                    {
                        CompanyTwilioId = c.Int(nullable: false, identity: true),
                        AuthToken = c.String(nullable: false, maxLength: 34, fixedLength: true),
                        AccountSid = c.String(nullable: false, maxLength: 34, fixedLength: true),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyTwilioId);
            
            CreateTable(
                "dbo.CompanyTypes",
                c => new
                    {
                        CompanyTypeId = c.Int(nullable: false, identity: true),
                        BusinessType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyTypeId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        Title = c.String(maxLength: 5),
                        BusinessaName = c.String(maxLength: 50),
                        EmailAddress = c.String(),
                        Street = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        State = c.String(maxLength: 2),
                        Zip = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        CompanyId = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.EmployeeSchedules",
                c => new
                    {
                        EmployeeScheduleId = c.Int(nullable: false, identity: true),
                        ScheduleDate = c.DateTime(nullable: false),
                        FromTime = c.DateTime(nullable: false),
                        ToTime = c.DateTime(nullable: false),
                        AvailableSlots = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeScheduleId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.CompanyCustomers",
                c => new
                    {
                        Company_CompanyId = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Company_CompanyId, t.Customer_CustomerId })
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId, cascadeDelete: false)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId, cascadeDelete: false)
                .Index(t => t.Company_CompanyId)
                .Index(t => t.Customer_CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "EmployeeScheduleId", "dbo.EmployeeSchedules");
            DropForeignKey("dbo.Appointments", "AppointmentTypeId", "dbo.AppointmentTypes");
            DropForeignKey("dbo.AppointmentTypes", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Employees", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.EmployeeSchedules", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Appointments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.CompanyCustomers", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CompanyCustomers", "Company_CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Appointments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Companies", "CompanyTypeId", "dbo.CompanyTypes");
            DropForeignKey("dbo.Companies", "CompanyTwilioId", "dbo.CompanyTwilios");
            DropForeignKey("dbo.CompanyPhoneNumbers", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Appointments", "CompanyId", "dbo.Companies");
            DropIndex("dbo.CompanyCustomers", new[] { "Customer_CustomerId" });
            DropIndex("dbo.CompanyCustomers", new[] { "Company_CompanyId" });
            DropIndex("dbo.EmployeeSchedules", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "CompanyId" });
            DropIndex("dbo.CompanyPhoneNumbers", new[] { "CompanyId" });
            DropIndex("dbo.Companies", new[] { "CompanyTwilioId" });
            DropIndex("dbo.Companies", new[] { "CompanyTypeId" });
            DropIndex("dbo.AppointmentTypes", new[] { "CompanyId" });
            DropIndex("dbo.Appointments", new[] { "EmployeeScheduleId" });
            DropIndex("dbo.Appointments", new[] { "CustomerId" });
            DropIndex("dbo.Appointments", new[] { "EmployeeId" });
            DropIndex("dbo.Appointments", new[] { "CompanyId" });
            DropIndex("dbo.Appointments", new[] { "AppointmentTypeId" });
            DropTable("dbo.CompanyCustomers");
            DropTable("dbo.EmployeeSchedules");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.CompanyTypes");
            DropTable("dbo.CompanyTwilios");
            DropTable("dbo.CompanyPhoneNumbers");
            DropTable("dbo.Companies");
            DropTable("dbo.AppointmentTypes");
            DropTable("dbo.Appointments");
        }
    }
}
