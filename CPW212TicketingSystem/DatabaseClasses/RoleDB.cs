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

        public static bool Add(Role role)
        {
            var db = new TicketingSystemDBContext();
            Role r = db.Roles.Find(role.RoleID);

            if (r == null)
            {
                db.Roles.Add(role);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
