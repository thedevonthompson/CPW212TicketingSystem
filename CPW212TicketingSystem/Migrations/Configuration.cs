namespace CPW212TicketingSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CPW212TicketingSystem.TicketingSystemDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CPW212TicketingSystem.TicketingSystemDBContext context)
        {
            Role FullPower = new Role(id: 100, isTech: true, name: "Administrator", editRoles: true, editUsers: true, assign: true, delete: true, level: 5, priority: true);
            Role LowestPower = new Role(id: 102, isTech: false, name: "Low", editRoles: false, assign: false, delete: false, editUsers: false, level: 4, priority: true);

            User Tech = new User(id: 1, fname: "Alex", lname: "Ramirez", username: "Admin", password: "123", role: FullPower, tickets: null);
            User User = new User(id: 1, fname: "Mr.", lname: "Meow", username: "CatPetter", password: "123", role: LowestPower, tickets: null);


            Priority Critical = new Priority(id: 4, name: "***** hitting the fan", level: 4);
            Priority Medium = new Priority(id: 2, name: "Medium", level: 2);
            Priority Low = new Priority(id: 1, name: "Low", level: 1);

            Ticket tick1 = new Ticket(id: 101, user: Tech, assignedUsers: null, comments: null, complete: false, created: DateTime.Now, updated: DateTime.Now, due: null, history: null, p: Critical, title: "TechMadeTicket");
            Ticket tick2 = new Ticket(id: 102, user: User, assignedUsers: null, comments: null, complete: false, created: DateTime.Now, updated: DateTime.Now, due: null, history: null, p: Low, title: "TechMadeTicket");




            context.Comments.AddOrUpdate(c => c.CommentID,
                new Comment("Tick 1 Public", false, DateTime.Now, tick1, User),
                new Comment("Tick 1 Internal", true, DateTime.Now, tick1, Tech),
                new Comment("Tick 2 public", true, DateTime.Now, tick2, User),
                new Comment("Tick 2 Internal", true, DateTime.Now, tick2, Tech)


            );



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
