namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderInfo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Costumers", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.OrderItems", "CostumerId", "dbo.Costumers");
            DropIndex("dbo.Costumers", new[] { "Book_Id" });
            DropIndex("dbo.OrderItems", new[] { "CostumerId" });
            RenameColumn(table: "dbo.OrderItems", name: "CostumerId", newName: "Costumer_Id");
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Costumer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Costumers", t => t.Costumer_Id)
                .Index(t => t.Costumer_Id);
            
            AddColumn("dbo.OrderItems", "Count", c => c.Int(nullable: false));
            AddColumn("dbo.OrderItems", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderItems", "ReturnDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.OrderItems", "Order_Id", c => c.Int());
            AlterColumn("dbo.Books", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.OrderItems", "Costumer_Id", c => c.Int());
            CreateIndex("dbo.OrderItems", "Costumer_Id");
            CreateIndex("dbo.OrderItems", "Order_Id");
            AddForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders", "Id");
            AddForeignKey("dbo.OrderItems", "Costumer_Id", "dbo.Costumers", "Id");
            DropColumn("dbo.Costumers", "Book_Id");
            DropColumn("dbo.OrderItems", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Costumers", "Book_Id", c => c.Int());
            DropForeignKey("dbo.OrderItems", "Costumer_Id", "dbo.Costumers");
            DropForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Costumer_Id", "dbo.Costumers");
            DropIndex("dbo.Orders", new[] { "Costumer_Id" });
            DropIndex("dbo.OrderItems", new[] { "Order_Id" });
            DropIndex("dbo.OrderItems", new[] { "Costumer_Id" });
            AlterColumn("dbo.OrderItems", "Costumer_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "Price", c => c.Decimal(nullable: false, storeType: "money"));
            DropColumn("dbo.OrderItems", "Order_Id");
            DropColumn("dbo.OrderItems", "ReturnDate");
            DropColumn("dbo.OrderItems", "Price");
            DropColumn("dbo.OrderItems", "Count");
            DropTable("dbo.Orders");
            RenameColumn(table: "dbo.OrderItems", name: "Costumer_Id", newName: "CostumerId");
            CreateIndex("dbo.OrderItems", "CostumerId");
            CreateIndex("dbo.Costumers", "Book_Id");
            AddForeignKey("dbo.OrderItems", "CostumerId", "dbo.Costumers", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Costumers", "Book_Id", "dbo.Books", "Id");
        }
    }
}
