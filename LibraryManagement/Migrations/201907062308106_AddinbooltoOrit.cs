namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddinbooltoOrit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "IsHave", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderItems", "IsHave");
        }
    }
}
