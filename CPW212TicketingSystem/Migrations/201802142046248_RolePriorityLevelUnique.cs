namespace CPW212TicketingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolePriorityLevelUnique : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "Level", c => c.Byte(nullable: false));
            AddColumn("dbo.Priorities", "Level", c => c.Byte(nullable: false));
            AlterColumn("dbo.Tickets", "LastUpdated", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Roles", "Level", unique: true);
            CreateIndex("dbo.Priorities", "Level", unique: true);
            DropColumn("dbo.Roles", "RoleLevel");
            DropColumn("dbo.Priorities", "PriorityLevel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Priorities", "PriorityLevel", c => c.Byte(nullable: false));
            AddColumn("dbo.Roles", "RoleLevel", c => c.Byte(nullable: false));
            DropIndex("dbo.Priorities", new[] { "Level" });
            DropIndex("dbo.Roles", new[] { "Level" });
            AlterColumn("dbo.Tickets", "LastUpdated", c => c.DateTime());
            DropColumn("dbo.Priorities", "Level");
            DropColumn("dbo.Roles", "Level");
        }
    }
}
