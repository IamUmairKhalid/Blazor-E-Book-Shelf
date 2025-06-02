using System.ComponentModel.DataAnnotations;

namespace E_Book_site.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(150, ErrorMessage = "Title cannot exceed 150 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Author is required.")]
        [MaxLength(100, ErrorMessage = "Author name cannot exceed 100 characters.")]
        public string Author { get; set; } = string.Empty;

        [MaxLength(50, ErrorMessage = "Genre cannot exceed 50 characters.")]
        public string Genre { get; set; } = string.Empty;

        [MaxLength(13, ErrorMessage = "ISBN cannot exceed 13 characters.")]
        public string ISBN { get; set; } = string.Empty;

        public DateOnly? PublishDate { get; set; }

        [MaxLength(2000, ErrorMessage = "Description cannot exceed 2000 characters.")]
        public string Description { get; set; } = string.Empty;

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        public double Rating { get; set; } = 0;

        [Range(0, int.MaxValue, ErrorMessage = "Rating count cannot be negative.")]
        public int RatingCount { get; set; } = 0;

        [Required(ErrorMessage = "Cover URL is Required")]
        [MaxLength(500, ErrorMessage = "Cover URL cannot exceed 500 characters.")]
        public string CoverUrl { get; set; } = string.Empty;

        [Range(1, 10000, ErrorMessage = "Pages must be between 1 and 10,000.")]
        public int Pages { get; set; } = 0;

        [Url(ErrorMessage = "Book link must be a valid URL.")]
        [MaxLength(500, ErrorMessage = "Book link cannot exceed 500 characters.")]
        public string Link { get; set; } = string.Empty;

        public ICollection<BooksLogs> BookLogs { get; set; } = new List<BooksLogs>();
    }
}
