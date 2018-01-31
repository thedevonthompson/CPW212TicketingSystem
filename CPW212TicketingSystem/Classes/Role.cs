using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        /// <summary>
        /// A number representing the hierarchical order of roles.
        /// </summary>
        [Required]
        public byte RoleLevel { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        public bool IsTechnician { get; set; }

        public bool CanDeleteTickets { get; set; }

        public bool CanChangePriority { get; set; }

        public bool CanAssignTickets { get; set; }

        public bool CanEditRoles { get; set; }

        public bool CanEditUsers { get; set; }
    }
}
