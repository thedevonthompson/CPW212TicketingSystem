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
            db.Tickets.Add(t);
            db.SaveChanges();
        }

        #endregion

        #region Read

        public static List<Ticket> GetAllTickets()
        {
            return new TicketingSystemDBContext().Tickets.ToList();
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
