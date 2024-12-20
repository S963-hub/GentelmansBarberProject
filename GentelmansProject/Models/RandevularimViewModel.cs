using GentelmansProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GentelmansProject.Models
{
    public class RandevularimViewModel
    {
        [Key]
        public string UserID { get; set; }
        public string BerberAdi { get; set; } = string.Empty;
        public string Servisler { get; set; } = string.Empty;
        public DateTime Tarih { get; set; }
        public string Saat { get; set; } = string.Empty;
        public decimal ToplamFiyat { get; set; }
        public string Notlar { get; set; } = string.Empty;
    }
}
