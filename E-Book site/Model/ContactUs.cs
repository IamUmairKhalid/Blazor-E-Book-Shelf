using System.ComponentModel.DataAnnotations;

namespace E_Book_site.Model
{ 
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot be more than 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        [StringLength(150, ErrorMessage = "Subject cannot be more than 150 characters.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        [StringLength(500, ErrorMessage = "Message cannot be more than 500 characters.")]
        public string Message { get; set; }
        

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
