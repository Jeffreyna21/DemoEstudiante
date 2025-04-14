using System.ComponentModel.DataAnnotations;

namespace DemoEstudiante.Models
{
    public class Facultad
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
       
    }
}
