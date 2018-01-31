using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(40)]
        public string Username { get; set; }

        [Required]
        [StringLength(128)]
        public string Password { get; set; }

        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        /// <summary>
        /// All of the tickets assigned to a user.
        /// </summary>
        public virtual ICollection<Ticket> AssignedTickets { get; set; }

        public virtual Role Role { get; set; }
    }
}
