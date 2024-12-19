using System;
using System.ComponentModel.DataAnnotations;

namespace GentelmansProject.Models
{
    public class Randevular
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Müşteri Adı")]
        public string? MusteriAdi { get; set; }

        [Required]
        [Display(Name = "Kuaför Adı")]
        public string CalisanAdi { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Ücret")]
        public decimal Ucret { get; set; }

        [Required]
        [Display(Name = "Süre (Dakika)")]
        public int Sure { get; set; }

        [Required]
        [Display(Name = "Randevu Tarihi")]
        public DateTime RandevuTarihi { get; set; }

        [Required]
        [Display(Name = "Onay Durumu")]
        public bool OnayDurumu { get; set; } = false;

        [Required]
        public string UserId { get; set; } // Randevuyu alan kullanıcı
    }
}
