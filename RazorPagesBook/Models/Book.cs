using System.ComponentModel.DataAnnotations;

namespace RazorPagesBook.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Description { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Author { get; set; } = string.Empty;

        [Display(Name = "Created At")]
        [DataType(DataType.Date)]
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "Updated At")]
        [DataType(DataType.Date)]
        public DateTime? UpdatedAt { get; set; }

    }
}
