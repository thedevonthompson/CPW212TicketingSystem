namespace CPW212TicketingSystem
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TicketingSystemDBContext : DbContext
    {
        // Your context has been configured to use a 'TicketingSystemDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CPW212TicketingSystem.TicketingSystemDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TicketingSystemDBContext' 
        // connection string in the application configuration file.
        public TicketingSystemDBContext()
            : base("name=TicketingSystemDBContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>()
                .HasMany<User>(t => t.AssignedUsers)
                .WithMany(u => u.AssignedTickets)
                .Map(tu =>
                    {
                        tu.MapLeftKey("TicketID");
                        tu.MapRightKey("UserID");
                        tu.ToTable("TicketUsers");
                    }
                );
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}