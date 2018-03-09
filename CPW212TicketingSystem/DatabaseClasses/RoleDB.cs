using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    static class RoleDB
    {
        public static List<Role> GetAllRoles()
        {
            return new TicketingSystemDBContext().Roles.ToList();
        }

        public static void Add(Role role)
        {
            var db = new TicketingSystemDBContext();
            db.Roles.Add(role);
            db.SaveChanges();
        }

        public static bool Update(Role role)
        {
            var db = new TicketingSystemDBContext();
            Role r = db.Roles.Find(role.RoleID);

            if (r == null)
            {
                return false;
            }
            else
            {
                r.Level = role.Level;
                r.Name = role.Name;
                r.IsTechnician = role.IsTechnician;
                r.CanDeleteTickets = role.CanDeleteTickets;
                r.CanChangePriority = role.CanChangePriority;
                r.CanAssignTickets = role.CanAssignTickets;
                r.CanEditRoles = role.CanEditRoles;
                r.CanEditUsers = role.CanEditUsers;
                db.SaveChanges();
                return true;
            }
        }
    }
}
