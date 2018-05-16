using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kasaki.Entities
{
    public class Departament1
    {
        [Key]
        //   [Required]
        public int DepPk { get; set; }

        [Required] [MaxLength(50)] public string Name { get; set; }

        [MaxLength(5)] public string Building { get; set; }

        //может сделать список от одного до 10
        //name уникальный не может повторяться
        public ICollection<Teacher1> Teachers { get; set; }
        public ICollection<Group1> Groups { get; set; }
    }
}