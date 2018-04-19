namespace Curs_3_1_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CompanyName = c.String(),
                        ContactName = c.String(),
                        ContactTitle = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nume = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "OrderId", "dbo.Orders");
            DropIndex("dbo.Customers", new[] { "OrderId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
