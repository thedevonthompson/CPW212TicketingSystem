using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    public class Ticket
    {
        [Key]
        public int TicketID { get; set; }

        [Required]
        [StringLength(80)]
        public string Title { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public DateTime? LastUpdated { get; set; }

        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The User who created the ticket.
        /// </summary>
        public virtual User User { get; set; }

        public virtual Priority Priority { get; set; }

        /// <summary>
        /// An array of all the users assigned to a ticket.
        /// </summary>
        public virtual ICollection<User> AssignedUsers { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<String> History { get; set; }
    }
}
