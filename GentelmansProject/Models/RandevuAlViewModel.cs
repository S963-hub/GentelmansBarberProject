using System;
using System.ComponentModel.DataAnnotations;

namespace GentelmansProject.Models
{
    public class RandevuAlViewModel
    {
        public int BerberId { get; set; } // Seçilen Berber Id
        public string ServisIds { get; set; }  // Seçilen Servislerin Id'leri (virgülle ayrılmış)

        [Required]
        [DataType(DataType.Date)]
        public DateTime RandevuTarihi { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public string RandevuSaati { get; set; }

        [MaxLength(500)]
        public string Notlar { get; set; }
    }
}
