using System.ComponentModel.DataAnnotations;

namespace E_Book_site.Model
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mission is required.")]
        [StringLength(1000, ErrorMessage = "Mission cannot exceed 1000 characters.")]
        public string Mission { get; set; }

        [Required(ErrorMessage = "Vision is required.")]
        [StringLength(1000, ErrorMessage = "Vision cannot exceed 1000 characters.")]
        public string Vision { get; set; }

        [Required(ErrorMessage = "Contact email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [MaxLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact phone is required.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        [MaxLength(20, ErrorMessage = "Phone number cannot exceed 20 characters.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Contact address is required.")]
        [MaxLength(250, ErrorMessage = "Address cannot exceed 250 characters.")]
        public string Address { get; set; }
    }
}
