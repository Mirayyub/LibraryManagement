namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeprice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderInfoes", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderInfoes", "Price", c => c.Decimal(nullable: false, storeType: "money"));
        }
    }
}
