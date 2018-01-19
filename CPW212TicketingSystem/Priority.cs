using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    class Priority
    {
        [Key]
        public int PriorityID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
