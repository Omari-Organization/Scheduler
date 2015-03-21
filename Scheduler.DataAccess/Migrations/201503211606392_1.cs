namespace Scheduler.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, defaultValue: string.Empty),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        AppointmentTypeId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false, defaultValue: true),
                        CancellationDate = c.DateTime(),
                        EmployeeScheduleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: false)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: false)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.AppointmentTypes", t => t.AppointmentTypeId, cascadeDelete: false)
                .ForeignKey("dbo.EmployeeSchedules", t => t.EmployeeScheduleId, cascadeDelete: false)
                .Index(t => t.AppointmentTypeId)
                .Index(t => t.ClientId)
                .Index(t => t.EmployeeId)
                .Index(t => t.CustomerId)
                .Index(t => t.EmployeeScheduleId);
            
            CreateTable(
                "dbo.AppointmentTypes",
                c => new
                    {
                        AppointmentTypeId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 8000, unicode: false, defaultValue: string.Empty),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentTypeId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: false)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false, defaultValue: true),
                        ClientTypeId = c.Int(nullable: false),
                        Address_Street = c.String(maxLength: 50, defaultValue:string.Empty),
                        Address_City = c.String(maxLength: 50, defaultValue:string.Empty),
                        Address_State = c.String(maxLength: 2,defaultValue:string.Empty),
                        Address_Zip = c.String(maxLength: 10, defaultValue: string.Empty),
                        Name_FirstName = c.String(maxLength: 50, defaultValue: string.Empty),
                        Name_LastName = c.String(maxLength: 50, defaultValue: string.Empty),
                        Name_MiddleName = c.String(maxLength: 50, defaultValue: string.Empty),
                        Name_Title = c.String(maxLength: 5, defaultValue: string.Empty),
                        Name_BusinessName = c.String(maxLength: 50, defaultValue: string.Empty),
                        CreatedDate = c.DateTime(nullable: false, defaultValue: DateTime.Now),
                        ClientTwilioId = c.Int(nullable: false, defaultValue:0),
                        TimeZone = c.String(maxLength: 8000, unicode: false, defaultValue: "Eastern Standard Time"),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.ClientTwilios", t => t.ClientTwilioId, cascadeDelete: false)
                .ForeignKey("dbo.ClientTypes", t => t.ClientTypeId, cascadeDelete: false)
                .Index(t => t.ClientTypeId)
                .Index(t => t.ClientTwilioId);
            
            CreateTable(
                "dbo.ClientPhoneNumbers",
                c => new
                    {
                        ClientPhoneNumberId = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(nullable: false, maxLength: 12, defaultValue: string.Empty),
                        IsCellPhone = c.Boolean(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientPhoneNumberId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: false)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.ClientTwilios",
                c => new
                    {
                        ClientTwilioId = c.Int(nullable: false, identity: true),
                        AuthToken = c.String(nullable: false),
                        AccountSid = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClientTwilioId);
            
            CreateTable(
                "dbo.ClientTypes",
                c => new
                    {
                        ClientTypeId = c.Int(nullable: false, identity: true),
                        _ClientType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientTypeId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name_FirstName = c.String(maxLength: 50),
                        Name_LastName = c.String(maxLength: 50),
                        Name_MiddleName = c.String(maxLength: 50),
                        Name_Title = c.String(maxLength: 5),
                        Name_BusinessName = c.String(maxLength: 50),
                        EmailAddress = c.String(),
                        Address_Street = c.String(maxLength: 50),
                        Address_City = c.String(maxLength: 50),
                        Address_State = c.String(maxLength: 2),
                        Address_Zip = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50, defaultValue: string.Empty),
                        LastName = c.String(maxLength: 50, defaultValue:string.Empty),
                        MiddleName = c.String(maxLength: 50, defaultValue: string.Empty),
                        ClientId = c.Int(nullable: false),
                        PhoneNumber = c.String(maxLength:10, defaultValue:string.Empty),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: false)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.EmployeeSchedules",
                c => new
                    {
                        EmployeeScheduleId = c.Int(nullable: false, identity: true),
                        ScheduleDate = c.DateTime(nullable: false),
                        FromTime = c.DateTime(nullable: false),
                        ToTime = c.DateTime(nullable: false),
                        AvailableSlots = c.Int(nullable: false, defaultValue: 0),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeScheduleId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.ClientCustomers",
                c => new
                    {
                        Client_ClientId = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Client_ClientId, t.Customer_CustomerId })
                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete: false)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId, cascadeDelete: true)
                .Index(t => t.Client_ClientId)
                .Index(t => t.Customer_CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "EmployeeScheduleId", "dbo.EmployeeSchedules");
            DropForeignKey("dbo.Appointments", "AppointmentTypeId", "dbo.AppointmentTypes");
            DropForeignKey("dbo.AppointmentTypes", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Employees", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.EmployeeSchedules", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Appointments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.ClientCustomers", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.ClientCustomers", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.Appointments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Clients", "ClientTypeId", "dbo.ClientTypes");
            DropForeignKey("dbo.Clients", "ClientTwilioId", "dbo.ClientTwilios");
            DropForeignKey("dbo.ClientPhoneNumbers", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Appointments", "ClientId", "dbo.Clients");
            DropIndex("dbo.ClientCustomers", new[] { "Customer_CustomerId" });
            DropIndex("dbo.ClientCustomers", new[] { "Client_ClientId" });
            DropIndex("dbo.EmployeeSchedules", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "ClientId" });
            DropIndex("dbo.ClientPhoneNumbers", new[] { "ClientId" });
            DropIndex("dbo.Clients", new[] { "ClientTwilioId" });
            DropIndex("dbo.Clients", new[] { "ClientTypeId" });
            DropIndex("dbo.AppointmentTypes", new[] { "ClientId" });
            DropIndex("dbo.Appointments", new[] { "EmployeeScheduleId" });
            DropIndex("dbo.Appointments", new[] { "CustomerId" });
            DropIndex("dbo.Appointments", new[] { "EmployeeId" });
            DropIndex("dbo.Appointments", new[] { "ClientId" });
            DropIndex("dbo.Appointments", new[] { "AppointmentTypeId" });
            DropTable("dbo.ClientCustomers");
            DropTable("dbo.EmployeeSchedules");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.ClientTypes");
            DropTable("dbo.ClientTwilios");
            DropTable("dbo.ClientPhoneNumbers");
            DropTable("dbo.Clients");
            DropTable("dbo.AppointmentTypes");
            DropTable("dbo.Appointments");
        }
    }
}
