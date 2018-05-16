using System.ComponentModel.DataAnnotations;

namespace Kasaki.Entities
{
    public class User1
    {
        [Key][Required]
        public  int UsrPk { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Name { get; set; }
    }
}