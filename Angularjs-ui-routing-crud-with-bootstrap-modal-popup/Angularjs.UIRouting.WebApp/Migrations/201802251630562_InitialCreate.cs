namespace Angularjs.UIRouting.WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Phone = c.String(nullable: false),
                        Fax = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        ZipCode = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
            DropTable("dbo.Contacts");
        }
    }
}
