using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GentelmansProject.Models
{
    public class Randevular
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BerberId { get; set; }

        [ForeignKey("BerberId")]
        public Berber Berber { get; set; } // İlişkili berber

        [Required]
        public string KullaniciId { get; set; } = string.Empty;

        [Required]
        public string ServisIds { get; set; }  // Virgülle ayrılmış servis ID'leri

        [Required]
        [DataType(DataType.Date)]
        public DateTime RandevuTarihi { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public string RandevuSaati { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ToplamFiyat { get; set; } // Hesaplanan toplam fiyat

        public string Notlar { get; set; } = string.Empty;
        public bool Onaylandi { get; internal set; }
    }
}
