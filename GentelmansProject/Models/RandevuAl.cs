using System;
using System.ComponentModel.DataAnnotations;

namespace GentelmansProject.Models
{
    public class RandevuAl
    {
        [Required]
        [Display(Name = "Müşteri Adı")]
        public string? MusteriAdi { get; set; }
/*
        [Required]
        [Display(Name = "İşlem Türü")]
        public IslemTuru IslemTuru { get; set; }  // Enum türünde işlem seçimi*/

        [Required]
        [Display(Name = "Ücret")]
        [Range(0, 1000, ErrorMessage = "Ücret 0 ile 1000 arasında olmalıdır.")]
        public decimal Ucret { get; set; }

        [Required]
        [Display(Name = "Süre (Dakika)")]
        public int Sure { get; set; }

        [Required]
        [Display(Name = "Randevu Tarihi")]
        [DataType(DataType.DateTime)]
        public DateTime RandevuTarihi { get; set; }

        [Required]
        [Display(Name = "Kuaför Adı")]
        public string CalisanAdi { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Onay Durumu")]
        public bool OnayDurumu { get; set; } = false;
    }
}
