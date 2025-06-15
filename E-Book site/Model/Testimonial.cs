using System.ComponentModel.DataAnnotations;

namespace E_Book_site.Model
{
    public class Testimonial
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        [StringLength(1000, ErrorMessage = "Content cannot exceed 1000 characters.")]
        public string Content { get; set; }

        [Url(ErrorMessage = "Invalid image URL.")]
        [StringLength(500, ErrorMessage = "Image URL cannot exceed 500 characters.")]
        public string ImageUrl { get; set; }

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        public double Rating { get; set; } = 0.0;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
