using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212TicketingSystem
{
    public class Priority
    {
        [Key]
        public int? PriorityID { get; set; }

        /// <summary>
        /// A number representing the hierarchical order of priority.
        /// </summary>
        [Required]
        [Index(IsUnique = true)]
        public byte Level { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        /// <summary>
        /// This constructor exists to make entity framework work.
        /// https://stackoverflow.com/questions/31543255/why-must-i-have-a-parameterless-constructor-for-code-first-entity-framework
        /// </summary>
        private Priority() { }

        public Priority(Priority p)
        : this(p.PriorityID, p.Level, p.Name) {}

        /// <summary>
        /// This contructor should be used when creating a priority that's not in the database yet.
        /// It sets the PriorityID to null.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="name"></param>
        public Priority(byte level, string name)
        : this(null, level, name) {}

        public Priority(int? id, byte level, string name)
        {
            PriorityID = id;
            Level = level;
            Name = name;
        }

        /// <summary>
        /// Returns a string value that represents the priority.
        /// </summary>
        /// <returns>The name of the priority</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Allows sorting of a collection of priority objects.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Priority other)
        {
            return Level.CompareTo(other.Level);
        }
    }
}
