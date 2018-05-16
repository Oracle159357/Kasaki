using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasaki.Entities
{
    public class Room1
    {
        [Key]
        public int RomPk { get; set; }
        [Required]
        public int Num { get; set; }
        [Required]
        public string Building { get; set; }

     //   public Subject Disciplene { get; set; }
     //   public DBTeacher Teacher { get; set; }
    }
}
