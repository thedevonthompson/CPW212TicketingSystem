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
    }
}
