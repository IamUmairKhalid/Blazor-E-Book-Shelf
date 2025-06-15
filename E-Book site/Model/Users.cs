using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Book_site.Model
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\$@#])[A-Za-z\d\$@#]{8,}$",
        ErrorMessage = "Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one digit, and one special character ($, @, or #).")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateOnly? BirthDate { get; set; }

        [Required(ErrorMessage = "Profile picture URL Required.")]
        [StringLength(300, ErrorMessage = "Profile picture URL cannot exceed 300 characters.")]
        public string? ProfilePictureUrl { get; set; } = "alt_profile_pic.jpg";

        [StringLength(500, ErrorMessage = "Bio cannot exceed 500 characters.")]
        public string? Bio { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Location cannot exceed 100 characters.")]
        public string? Location { get; set; } = string.Empty;

        public bool? Subscription { get; set; } = true;

        [Required(ErrorMessage = "Role is required.")]
        [RegularExpression("Admin|User", ErrorMessage = "Role must be either 'Admin' or 'User'.")]
        public string? Role { get; set; } = "User";

        
        [StringLength(100, ErrorMessage = "Designation cannot exceed 100 characters.")]
        public string? Designation { get; set; } = string.Empty;
        public ICollection<BooksLogs> BookLogs { get; set; } = new List<BooksLogs>();
    }
}
