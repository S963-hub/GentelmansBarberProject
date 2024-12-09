﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Ge.Models
{
    public class RandevuAl
    {
        [Key]
        public int RandevuId { get; set; }

        [Required]
        [Display(Name = "Müşteri Adı")]
        public string MusteriAdi { get; set; }

        [Required]
        [Display(Name = "İşlem Türü")]
        public IslemTuru IslemTuru { get; set; }  // Enum türünde işlem seçimi

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
        [Display(Name = "Kuaför/Çalışan Adı")]
        public string CalisanAdi { get; set; }

        [Required]
        [Display(Name = "Onay Durumu")]
        public bool OnayDurumu { get; set; } = false;
    }
}
