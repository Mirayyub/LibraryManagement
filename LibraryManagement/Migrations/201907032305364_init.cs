namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Costumers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNo = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CostumerId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        OrderInfoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Costumers", t => t.CostumerId, cascadeDelete: false)
                .ForeignKey("dbo.OrderInfoes", t => t.OrderInfoId, cascadeDelete: false)
                .Index(t => t.CostumerId)
                .Index(t => t.BookId)
                .Index(t => t.OrderInfoId);
            
            CreateTable(
                "dbo.OrderInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Costumers", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.OrderItems", "OrderInfoId", "dbo.OrderInfoes");
            DropForeignKey("dbo.OrderItems", "CostumerId", "dbo.Costumers");
            DropForeignKey("dbo.OrderItems", "BookId", "dbo.Books");
            DropIndex("dbo.OrderItems", new[] { "OrderInfoId" });
            DropIndex("dbo.OrderItems", new[] { "BookId" });
            DropIndex("dbo.OrderItems", new[] { "CostumerId" });
            DropIndex("dbo.Costumers", new[] { "Book_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.OrderInfoes");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Costumers");
            DropTable("dbo.Books");
        }
    }
}
