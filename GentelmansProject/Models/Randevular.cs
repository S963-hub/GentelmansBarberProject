using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GentelmansProject.Models
{
    public class Randevular
    {
        [Key]
        public int Id { get; set; } // Benzersiz kimlik

        [Required]
        public int BerberId { get; set; } // Berber tablosuna referans

        [ForeignKey("BerberId")]
        public Berber Berber { get; set; } // İlişkili berber

        [Required]
        public string KullaniciId { get; set; } = string.Empty; // Kullanıcı kimliği

        [ForeignKey("KullaniciId")]
        public ApplicationUser Kullanici { get; set; } // İlişkili kullanıcı

        [Required]
        public string ServisIds { get; set; } = string.Empty; // Servis Id'leri (ör. "1,2,3")

        [Required]
        [DataType(DataType.Date)]
        public DateTime RandevuTarihi { get; set; } // Randevu tarihi

        [Required]
        [DataType(DataType.Time)]
        public string RandevuSaati { get; set; } = string.Empty; // Randevu saati (örn: "14:30")

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ToplamFiyat { get; set; } // Toplam ücret

        public string Notlar { get; set; } = string.Empty;  // Kullanıcı notları (isteğe bağlı)
    }
}
