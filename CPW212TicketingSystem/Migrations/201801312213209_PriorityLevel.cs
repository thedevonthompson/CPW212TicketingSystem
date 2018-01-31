namespace CPW212TicketingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriorityLevel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Priorities", "PriorityLevel", c => c.Byte(nullable: false));
            CreateIndex("dbo.Users", "Username", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Username" });
            DropColumn("dbo.Priorities", "PriorityLevel");
        }
    }
}
