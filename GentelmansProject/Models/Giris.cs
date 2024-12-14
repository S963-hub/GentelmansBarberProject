using System.ComponentModel.DataAnnotations;

namespace GentelmansProject.Models
{
    public class Giris
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Alanı Zorunludur")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Alanı Zorunludur")]
        public string Password { get; set; } = string.Empty;

    }
}
