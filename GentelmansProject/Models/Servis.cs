namespace GentelmansProject.Models
{
    public class Servis
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HizmetSuresi { get; set; }
        public decimal HizmetFiyat { get; set; } // Decimal türünde olmalı
    }
}
