using System.ComponentModel.DataAnnotations;

namespace E_Book_site.Model
{
    public class Social
    {
        public int Id { get; set; }

        [Url(ErrorMessage = "Please enter a valid Facebook URL.")]
        [StringLength(255, ErrorMessage = "Facebook URL cannot exceed 255 characters.")]
        public string FB { get; set; } = string.Empty;

        [Url(ErrorMessage = "Please enter a valid Instagram URL.")]
        [StringLength(255, ErrorMessage = "Instagram URL cannot exceed 255 characters.")]
        public string Insta { get; set; } = string.Empty;

        [Url(ErrorMessage = "Please enter a valid LinkedIn URL.")]
        [StringLength(255, ErrorMessage = "LinkedIn URL cannot exceed 255 characters.")]
        public string LinkD { get; set; } = string.Empty;

        [Url(ErrorMessage = "Please enter a valid X (Twitter) URL.")]
        [StringLength(255, ErrorMessage = "X (Twitter) URL cannot exceed 255 characters.")]
        public string X { get; set; } = string.Empty;
    }
}
