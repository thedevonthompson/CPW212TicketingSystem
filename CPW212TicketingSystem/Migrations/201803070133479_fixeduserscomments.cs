namespace CPW212TicketingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixeduserscomments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false, maxLength: 280),
                        IsInternal = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        LastEdited = c.DateTime(),
                        User_UserID = c.Int(),
                        Ticket_TicketID = c.Int(),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .ForeignKey("dbo.Tickets", t => t.Ticket_TicketID)
                .Index(t => t.User_UserID)
                .Index(t => t.Ticket_TicketID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 80),
                        IsCompleted = c.Boolean(nullable: false),
                        Created = c.DateTime(nullable: false),
                        LastUpdated = c.DateTime(nullable: false),
                        DueDate = c.DateTime(),
                        Priority_PriorityID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.TicketID)
                .ForeignKey("dbo.Priorities", t => t.Priority_PriorityID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.Priority_PriorityID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 40),
                        Password = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 40),
                        LastName = c.String(nullable: false, maxLength: 40),
                        Role_RoleID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Roles", t => t.Role_RoleID)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Role_RoleID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        Level = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 80),
                        IsTechnician = c.Boolean(nullable: false),
                        CanDeleteTickets = c.Boolean(nullable: false),
                        CanChangePriority = c.Boolean(nullable: false),
                        CanAssignTickets = c.Boolean(nullable: false),
                        CanEditRoles = c.Boolean(nullable: false),
                        CanEditUsers = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RoleID)
                .Index(t => t.Level, unique: true);
            
            CreateTable(
                "dbo.Priorities",
                c => new
                    {
                        PriorityID = c.Int(nullable: false, identity: true),
                        Level = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.PriorityID)
                .Index(t => t.Level, unique: true);
            
            CreateTable(
                "dbo.TicketUsers",
                c => new
                    {
                        TicketID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TicketID, t.UserID })
                .ForeignKey("dbo.Tickets", t => t.TicketID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.TicketID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Tickets", "Priority_PriorityID", "dbo.Priorities");
            DropForeignKey("dbo.Comments", "Ticket_TicketID", "dbo.Tickets");
            DropForeignKey("dbo.TicketUsers", "UserID", "dbo.Users");
            DropForeignKey("dbo.TicketUsers", "TicketID", "dbo.Tickets");
            DropForeignKey("dbo.Users", "Role_RoleID", "dbo.Roles");
            DropForeignKey("dbo.Comments", "User_UserID", "dbo.Users");
            DropIndex("dbo.TicketUsers", new[] { "UserID" });
            DropIndex("dbo.TicketUsers", new[] { "TicketID" });
            DropIndex("dbo.Priorities", new[] { "Level" });
            DropIndex("dbo.Roles", new[] { "Level" });
            DropIndex("dbo.Users", new[] { "Role_RoleID" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Tickets", new[] { "User_UserID" });
            DropIndex("dbo.Tickets", new[] { "Priority_PriorityID" });
            DropIndex("dbo.Comments", new[] { "Ticket_TicketID" });
            DropIndex("dbo.Comments", new[] { "User_UserID" });
            DropTable("dbo.TicketUsers");
            DropTable("dbo.Priorities");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
            DropTable("dbo.Comments");
        }
    }
}
