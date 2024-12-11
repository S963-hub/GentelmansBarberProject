using System.ComponentModel.DataAnnotations;

namespace GentelmansProject.Models
{
    public class Kaydol
    {
        [Key]
        [Display(Name = "Email Adress")]
        [EmailAddress(ErrorMessage = "lütfen Email fırmatında girdiğinizi emin olnuz. ")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        public string Email { get; set; } = string.Empty;


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        public string Password { get; set; } = string.Empty;


        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [Compare("Password", ErrorMessage = "Lütfen yukardaki şifreyi tekrar giriniz. ")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
