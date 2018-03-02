using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        [Required]
        [MaxLength(280)]
        public string Text { get; set; }

        public bool IsInternal { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public DateTime? LastEdited { get; set; }

        /// <summary>
        /// The user that posted the comment.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// The ticket the comment was posted to.
        /// </summary>
        public virtual Ticket Ticket { get; set; }

        /// <summary>
        /// This constructor exists to make entity framework work.
        /// https://stackoverflow.com/questions/31543255/why-must-i-have-a-parameterless-constructor-for-code-first-entity-framework
        /// </summary>
        private Comment() { }

    }
}
