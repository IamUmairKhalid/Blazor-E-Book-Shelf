using System.ComponentModel.DataAnnotations;

namespace E_Book_site.Model
{
    public class BooksLogs
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Book ID is required.")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "User ID is required.")]
        public int UserId { get; set; }

        [MaxLength(13, ErrorMessage = "ISBN cannot exceed 13 characters.")]
        public string ISBN { get; set; } = string.Empty;

        public DateTime? UpdatedAt { get; set; }

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        public double? Rating { get; set; } = 0.0;

        public bool Favorite { get; set; } = false;

        [Required(ErrorMessage = "Status is required.")]
        [RegularExpression("Reading|Completed|NotOpend", ErrorMessage = "Status must be 'Reading', 'Completed', or 'NotOpend'.")]
        public string Status { get; set; } = "NotOpend";

        [Range(1, int.MaxValue, ErrorMessage = "Last seen page must be 1 or greater.")]
        public int? LastSeenPage { get; set; } = 0;

        [Range(0, 100, ErrorMessage = "Progress must be between 0 and 100 percent.")]
        public double? ProgressPercentage { get; set; } = 0.0;

        public Users User { get; set; }
        public Book Book { get; set; }
    }
}
