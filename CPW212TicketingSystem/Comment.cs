using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    class Comment
    {
        [Key]
        public int CommentID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        [ForeignKey("Ticket")]
        public int TicketID { get; set; }

        [Required]
        [MaxLength(280)]
        public string Text { get; set; }

        public bool IsInternal { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public DateTime? LastEdited { get; set; }

    }
}
