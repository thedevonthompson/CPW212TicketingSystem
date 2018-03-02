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
            db.Entry(t).State = EntityState.Added;
            // The following pieces of code prevent EF from trying to insert the priority or the user again.
            db.Entry(t.Priority).State = EntityState.Unchanged;
            db.Entry(t.User).State = EntityState.Unchanged;
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
