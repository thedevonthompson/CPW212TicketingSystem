using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    public class Role
    {
        [Key]
        public int? RoleID { get; set; }

        /// <summary>
        /// A number representing the hierarchical order of roles.
        /// </summary>
        [Required]
        [Index(IsUnique = true)]
        public byte Level { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        public bool IsTechnician { get; set; }

        public bool CanDeleteTickets { get; set; }

        public bool CanChangePriority { get; set; }

        public bool CanAssignTickets { get; set; }

        public bool CanEditRoles { get; set; }

        public bool CanEditUsers { get; set; }

        /// <summary>
        /// This constructor exists to make entity framework work.
        /// https://stackoverflow.com/questions/31543255/why-must-i-have-a-parameterless-constructor-for-code-first-entity-framework
        /// </summary>
        public Role() { }

        public Role(byte level, string name)
        : this(null, level, name, false, false, false, false, false, false) {}

        public Role(int? id, byte level, string name, bool isTech, bool delete, bool priority, bool assign, bool editRoles, bool editUsers)
        {
            RoleID = id;
            Level = level;
            Name = name;
            IsTechnician = isTech;
            CanDeleteTickets = delete;
            CanChangePriority = priority;
            CanAssignTickets = assign;
            CanEditRoles = editRoles;
            CanEditUsers = editUsers;
        }
    }
}
