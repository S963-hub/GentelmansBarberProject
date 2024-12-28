using System;
using System.Collections.Generic;

namespace GentelmansProject.Models
{
    public class RandevuViewModel
    {
        public int Id { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string RandevuSaati { get; set; }
        public List<string> ServisIsimleri { get; set; }
        public decimal ToplamFiyat { get; set; }
        public string Notlar { get; set; }
    }
}
