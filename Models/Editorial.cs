using System.ComponentModel.DataAnnotations;

namespace SimulacroLibros.Models
{
    public class Editorial
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Email { get; set; }
    }
}