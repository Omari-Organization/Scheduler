namespace Scheduler.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Clients", name: "Address_Street", newName: "Street");
            RenameColumn(table: "dbo.Clients", name: "Address_City", newName: "City");
            RenameColumn(table: "dbo.Clients", name: "Address_State", newName: "State");
            RenameColumn(table: "dbo.Clients", name: "Address_Zip", newName: "Zip");
            RenameColumn(table: "dbo.Clients", name: "Name_FirstName", newName: "FirstName");
            RenameColumn(table: "dbo.Clients", name: "Name_LastName", newName: "LastName");
            RenameColumn(table: "dbo.Clients", name: "Name_MiddleName", newName: "MiddleName");
            RenameColumn(table: "dbo.Clients", name: "Name_Title", newName: "Title");
            RenameColumn(table: "dbo.Clients", name: "Name_BusinessName", newName: "BusinessaName");
            RenameColumn(table: "dbo.Customers", name: "Name_FirstName", newName: "FirstName");
            RenameColumn(table: "dbo.Customers", name: "Name_LastName", newName: "LastName");
            RenameColumn(table: "dbo.Customers", name: "Name_MiddleName", newName: "MiddleName");
            RenameColumn(table: "dbo.Customers", name: "Name_Title", newName: "Title");
            RenameColumn(table: "dbo.Customers", name: "Name_BusinessName", newName: "BusinessaName");
            RenameColumn(table: "dbo.Customers", name: "Address_Street", newName: "Street");
            RenameColumn(table: "dbo.Customers", name: "Address_City", newName: "City");
            RenameColumn(table: "dbo.Customers", name: "Address_State", newName: "State");
            RenameColumn(table: "dbo.Customers", name: "Address_Zip", newName: "Zip");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Customers", name: "Zip", newName: "Address_Zip");
            RenameColumn(table: "dbo.Customers", name: "State", newName: "Address_State");
            RenameColumn(table: "dbo.Customers", name: "City", newName: "Address_City");
            RenameColumn(table: "dbo.Customers", name: "Street", newName: "Address_Street");
            RenameColumn(table: "dbo.Customers", name: "BusinessaName", newName: "Name_BusinessName");
            RenameColumn(table: "dbo.Customers", name: "Title", newName: "Name_Title");
            RenameColumn(table: "dbo.Customers", name: "MiddleName", newName: "Name_MiddleName");
            RenameColumn(table: "dbo.Customers", name: "LastName", newName: "Name_LastName");
            RenameColumn(table: "dbo.Customers", name: "FirstName", newName: "Name_FirstName");
            RenameColumn(table: "dbo.Clients", name: "BusinessaName", newName: "Name_BusinessName");
            RenameColumn(table: "dbo.Clients", name: "Title", newName: "Name_Title");
            RenameColumn(table: "dbo.Clients", name: "MiddleName", newName: "Name_MiddleName");
            RenameColumn(table: "dbo.Clients", name: "LastName", newName: "Name_LastName");
            RenameColumn(table: "dbo.Clients", name: "FirstName", newName: "Name_FirstName");
            RenameColumn(table: "dbo.Clients", name: "Zip", newName: "Address_Zip");
            RenameColumn(table: "dbo.Clients", name: "State", newName: "Address_State");
            RenameColumn(table: "dbo.Clients", name: "City", newName: "Address_City");
            RenameColumn(table: "dbo.Clients", name: "Street", newName: "Address_Street");
        }
    }
}
