using System.ComponentModel.DataAnnotations;

namespace SimulacroLibros.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
        public string? Language { get; set; }

        [Required]
        public DateTime PublicationDate { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? Status { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public required Author Author { get; set; }

        [Required]
        public int EditorialId { get; set; }

        [Required]
        public required Editorial Editorial { get; set; }
    }
}