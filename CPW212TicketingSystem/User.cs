using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// An array of all the tickets assigned to a user.
        /// </summary>
        public List<Ticket> AssignedTickets { get; set; }

        [ForeignKey("Role")]
        public int RoleID { get; set; }
    }
}
