namespace Scheduler.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ClientPhoneNumbers", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "ClientTwilioId", "dbo.ClientTwilios");
            DropForeignKey("dbo.Clients", "ClientTypeId", "dbo.ClientTypes");
            DropForeignKey("dbo.ClientCustomers", "Client_ClientId", "dbo.Clients");
            DropForeignKey("dbo.ClientCustomers", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Employees", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.AppointmentTypes", "ClientId", "dbo.Clients");
            DropIndex("dbo.Appointments", new[] { "ClientId" });
            DropIndex("dbo.AppointmentTypes", new[] { "ClientId" });
            DropIndex("dbo.Clients", new[] { "ClientTypeId" });
            DropIndex("dbo.Clients", new[] { "ClientTwilioId" });
            DropIndex("dbo.ClientPhoneNumbers", new[] { "ClientId" });
            DropIndex("dbo.Employees", new[] { "ClientId" });
            DropIndex("dbo.ClientCustomers", new[] { "Client_ClientId" });
            DropIndex("dbo.ClientCustomers", new[] { "Customer_CustomerId" });
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
                    })
                .PrimaryKey(t => t.CompanyId)
                .ForeignKey("dbo.CompanyTwilios", t => t.CompanyTwilioId, cascadeDelete: true)
                .ForeignKey("dbo.CompanyTypes", t => t.CompanyTypeId, cascadeDelete: true)
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
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.CompanyTwilios",
                c => new
                    {
                        CompanyTwilioId = c.Int(nullable: false, identity: true),
                        AuthToken = c.String(nullable: false),
                        AccountSid = c.String(nullable: false),
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
                "dbo.CompanyCustomers",
                c => new
                    {
                        Company_CompanyId = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Company_CompanyId, t.Customer_CustomerId })
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId, cascadeDelete: true)
                .Index(t => t.Company_CompanyId)
                .Index(t => t.Customer_CustomerId);
            
            AddColumn("dbo.Appointments", "CompanyId", c => c.Int(nullable: false));
            AddColumn("dbo.AppointmentTypes", "CompanyId", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "CompanyId");
            CreateIndex("dbo.AppointmentTypes", "CompanyId");
            CreateIndex("dbo.Employees", "CompanyId");
            AddForeignKey("dbo.Appointments", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: true);
            AddForeignKey("dbo.AppointmentTypes", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: true);
            DropColumn("dbo.Appointments", "ClientId");
            DropColumn("dbo.AppointmentTypes", "ClientId");
            DropColumn("dbo.Employees", "ClientId");
            DropTable("dbo.Clients");
            DropTable("dbo.ClientPhoneNumbers");
            DropTable("dbo.ClientTwilios");
            DropTable("dbo.ClientTypes");
            DropTable("dbo.ClientCustomers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ClientCustomers",
                c => new
                    {
                        Client_ClientId = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Client_ClientId, t.Customer_CustomerId });
            
            CreateTable(
                "dbo.ClientTypes",
                c => new
                    {
                        ClientTypeId = c.Int(nullable: false, identity: true),
                        _ClientType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientTypeId);
            
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
                "dbo.ClientPhoneNumbers",
                c => new
                    {
                        ClientPhoneNumberId = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(nullable: false, maxLength: 12),
                        IsCellPhone = c.Boolean(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientPhoneNumberId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        ClientTypeId = c.Int(nullable: false),
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
                        ClientTwilioId = c.Int(nullable: false),
                        TimeZone = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
            AddColumn("dbo.Employees", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.AppointmentTypes", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.Appointments", "ClientId", c => c.Int(nullable: false));
            DropForeignKey("dbo.AppointmentTypes", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Employees", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.CompanyCustomers", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CompanyCustomers", "Company_CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Companies", "CompanyTypeId", "dbo.CompanyTypes");
            DropForeignKey("dbo.Companies", "CompanyTwilioId", "dbo.CompanyTwilios");
            DropForeignKey("dbo.CompanyPhoneNumbers", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Appointments", "CompanyId", "dbo.Companies");
            DropIndex("dbo.CompanyCustomers", new[] { "Customer_CustomerId" });
            DropIndex("dbo.CompanyCustomers", new[] { "Company_CompanyId" });
            DropIndex("dbo.Employees", new[] { "CompanyId" });
            DropIndex("dbo.CompanyPhoneNumbers", new[] { "CompanyId" });
            DropIndex("dbo.Companies", new[] { "CompanyTwilioId" });
            DropIndex("dbo.Companies", new[] { "CompanyTypeId" });
            DropIndex("dbo.AppointmentTypes", new[] { "CompanyId" });
            DropIndex("dbo.Appointments", new[] { "CompanyId" });
            DropColumn("dbo.Employees", "CompanyId");
            DropColumn("dbo.AppointmentTypes", "CompanyId");
            DropColumn("dbo.Appointments", "CompanyId");
            DropTable("dbo.CompanyCustomers");
            DropTable("dbo.CompanyTypes");
            DropTable("dbo.CompanyTwilios");
            DropTable("dbo.CompanyPhoneNumbers");
            DropTable("dbo.Companies");
            CreateIndex("dbo.ClientCustomers", "Customer_CustomerId");
            CreateIndex("dbo.ClientCustomers", "Client_ClientId");
            CreateIndex("dbo.Employees", "ClientId");
            CreateIndex("dbo.ClientPhoneNumbers", "ClientId");
            CreateIndex("dbo.Clients", "ClientTwilioId");
            CreateIndex("dbo.Clients", "ClientTypeId");
            CreateIndex("dbo.AppointmentTypes", "ClientId");
            CreateIndex("dbo.Appointments", "ClientId");
            AddForeignKey("dbo.AppointmentTypes", "ClientId", "dbo.Clients", "ClientId", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "ClientId", "dbo.Clients", "ClientId", cascadeDelete: true);
            AddForeignKey("dbo.ClientCustomers", "Customer_CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.ClientCustomers", "Client_ClientId", "dbo.Clients", "ClientId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "ClientTypeId", "dbo.ClientTypes", "ClientTypeId", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "ClientTwilioId", "dbo.ClientTwilios", "ClientTwilioId", cascadeDelete: true);
            AddForeignKey("dbo.ClientPhoneNumbers", "ClientId", "dbo.Clients", "ClientId", cascadeDelete: true);
            AddForeignKey("dbo.Appointments", "ClientId", "dbo.Clients", "ClientId", cascadeDelete: true);
        }
    }
}
