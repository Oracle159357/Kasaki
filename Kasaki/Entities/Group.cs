using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kasaki.Entities
{
    public class Group1
    {
        [Key]
        public int GrpPk { get; set; }
       // [ForeignKey("Departament")]
        public Departament1 Departament { get; set; }
        [MaxLength(1)]
        public int Course { get; set; }
        [MaxLength(3)]
        public int Num { get; set; }
        public ICollection<Lecture1> Lectures { get; set; }
    }
}
