using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    public static class PriorityDB
    {
        public static void AddOrUpdate(Priority p)
        {
            if (p.PriorityID == null)
                Create(p);
            else
                Update(p);
        }

        #region Create

        public static void Create(Priority p)
        {
            var db = new TicketingSystemDBContext();
            db.Priorities.Add(p);
            db.SaveChanges();
        }

        #endregion

        #region Read

        public static List<Priority> GetAllPriorities()
        {
            return new TicketingSystemDBContext().Priorities.ToList();
        }

        #endregion

        #region Update

        public static void Update(Priority p)
        {
            var db = new TicketingSystemDBContext();
            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();
        }

        #endregion

        #region Delete

        public static void Delete(Priority p)
        {
            var db = new TicketingSystemDBContext();
            db.Entry(p).State = EntityState.Deleted;
            db.SaveChanges();
        }

        #endregion
    }
}
