namespace LibraryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AcademyComputer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "CustomerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderItems", "CustomerId");
        }
    }
}
