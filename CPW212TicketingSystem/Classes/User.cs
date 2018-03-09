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
        public int? UserID { get; set; }

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
        public virtual ICollection<Comment> CreatedComments { get; set; }

        public virtual Role Role { get; set; }

        /// <summary>
        /// This constructor exists to make entity framework work.
        /// https://stackoverflow.com/questions/31543255/why-must-i-have-a-parameterless-constructor-for-code-first-entity-framework
        /// </summary>
        private User() {}

        public User(User u)
        : this(u.UserID, u.Username, u.Password, u.FirstName, u.LastName, u.AssignedTickets, u.Role) {}

        /// <summary>
        /// This constructor should be used when creating a user that not already in the database.
        /// UserID is set to null.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="r"></param>
        public User(string username, string password, string fname, string lname, Role r)
        : this(null, username, password, fname, lname, new List<Ticket>(), r) {}

        public User(int? id, string username, string password, string fname, string lname, ICollection<Ticket> tickets, Role role)
        {
            UserID = id;
            Username = username;
            Password = password;
            FirstName = fname;
            LastName = lname;
            AssignedTickets = tickets;
            Role = role;
        }

        /// <summary>
        /// Returns a string representation of a user.
        /// </summary>
        /// <returns>A user's first then last name.</returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
