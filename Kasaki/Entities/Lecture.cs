using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kasaki.Entities
{
    public class Lecture1
    {
        [Key]
        public int LctPk { get; set; }
        
        public string Day { get; set; }
        public int Week { get; set; }
        public int Lesson { get; set; }

        public Group1 Group { get; set; }

        public Teacher1 Teacher { get; set; }

        public Room1 Room { get; set; }

        public Subject1 Subject { get; set; }

    }
}