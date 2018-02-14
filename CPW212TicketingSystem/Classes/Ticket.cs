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
        public int? TicketID { get; set; }

        [Required]
        [StringLength(80)]
        public string Title { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public DateTime LastUpdated { get; set; }

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

        public Ticket(Ticket t)
            : this(t.TicketID, t.Title, t.IsCompleted, t.Created, t.LastUpdated, t.DueDate, t.User, t.Priority, t.AssignedUsers, t.Comments, t.History) {}

        /// <summary>
        /// This overload is used when creating new tickets.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="due"></param>
        /// <param name="p"></param>
        public Ticket(string title, DateTime? due, Priority p)
        : this(null, title, false, DateTime.Now, null, due, State.CurrUser, p, new List<User>(), new List<Comment>(), new List<String>()) {}

        public Ticket(int? id, string title, bool complete, DateTime created, DateTime? updated, DateTime? due, User user, Priority p, ICollection<User> assignedUsers, ICollection<Comment> comments, ICollection<String> history)
        {
            TicketID = id;
            Title = title;
            IsCompleted = complete;
            Created = created;
            LastUpdated = updated ?? created;
            DueDate = due;
            User = user;
            Priority = p;
            AssignedUsers = assignedUsers;
            Comments = comments;
            History = history;
        }
    }
}
