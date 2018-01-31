using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    public class Priority
    {
        [Key]
        public int PriorityID { get; set; }

        /// <summary>
        /// A number representing the hierarchical order of priority.
        /// </summary>
        [Required]
        public byte PriorityLevel { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }
    }
}
