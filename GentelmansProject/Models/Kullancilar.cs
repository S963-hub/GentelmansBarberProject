using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GentelmansProject.Models
{
    public class Kullancilar
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu Alan Zorunludur")]
        [EmailAddress(ErrorMessage = "Lutfen Gecerli Bir Email Adresi Kullanilmalidir")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Bu alan Zorunludur")]
        public string Password { get; set; } = string.Empty;

        public DateTime CreateData { get; set; } = DateTime.Now;

    }


}
