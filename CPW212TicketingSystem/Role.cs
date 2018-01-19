using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Required]
        public byte RoleLevel { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsTechnician { get; set; }

        public bool CanDeleteTickets { get; set; }

        public bool CanChangePriority { get; set; }

        public bool CanAssignTickets { get; set; }

        public bool CanEditRoles { get; set; }

        public bool CanEditUsers { get; set; }
    }
}
