using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasaki.Entities
{
    public class Subject1
    {
        [Key]
        public int SbjPk { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

    }
}
