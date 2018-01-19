using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    class Ticket
    {
        [Key]
        public int TicketID { get; set; }

        /// <summary>
        /// The ID of the user who created the ticket.
        /// </summary>
        [ForeignKey("User")]
        public int UserID { get; set; }

        [ForeignKey("Priority")]
        public int PriorityID { get; set; }

        [Required]
        public string Title { get; set; }

        /// <summary>
        /// An array of all the users assigned to a ticket.
        /// </summary>
        public List<User> AssignedUsers { get; set; }

        public List<Comment> Comments { get; set; }

        public List<String> History { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public DateTime LastUpdated { get; set; }

        public DateTime DueDate { get; set; }
    }
}
