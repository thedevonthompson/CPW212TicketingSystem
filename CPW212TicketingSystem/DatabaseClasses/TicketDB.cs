using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    public static class TicketDB
    {
        private static TicketingSystemDBContext db = new TicketingSystemDBContext();

        public static void AddOrUpdate(Ticket t)
        {
            if (t.TicketID == null)
                Create(t);
            else
                Update(t);
        }

        #region Create

        public static void Create(Ticket t)
        {
            var db = new TicketingSystemDBContext();
            db.Users.Attach(t.User);
            db.Priorities.Attach(t.Priority);
            db.Tickets.Add(t);
            db.SaveChanges();
        }

        #endregion

        #region Read

        public static List<Ticket> GetAllTickets()
        {
            return new TicketingSystemDBContext().Tickets
                                                 .Include("User")
                                                 .Include("Priority")
                                                 .ToList();
        }

        public static List<Ticket> GetAllTicketsCreatedByUser(User currUser)
        {
            return new TicketingSystemDBContext().Tickets
                                                 .Include("User")
                                                 .Include("Priority")
                                                 .Where(t => t.User.UserID == currUser.UserID)
                                                 .OrderBy(t => t.Created)
                                                 .ToList();
        }

        public static Ticket FindTicketByID(int? id)
        {
            //return db.Tickets.SingleOrDefault(t => t.TicketID == id);
            return db.Tickets.Include("User").Single(t => t.TicketID == id);
        }

        #endregion

        #region Update

        public static void Update(Ticket t)
        {
            var db = new TicketingSystemDBContext();
            db.Entry(t).State = EntityState.Modified;
            db.SaveChanges();
        }

        #endregion

        #region Delete

        public static void Delete(Ticket t)
        {
            var db = new TicketingSystemDBContext();
            db.Entry(t).State = EntityState.Deleted;
            db.SaveChanges();
        }
        #endregion
    }
}
