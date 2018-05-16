using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasaki.Entities
{
   public class Teacher1
    {
        [Key]
        [Required]
        public int TchPk { get; set; }
        public Departament1 Departament { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Patronymic { get; set; }
        public ICollection<Lecture1> Lectures { get; set; }
    }
}
