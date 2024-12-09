namespace GentelmansProject.Models
{
    public class Randevular
    {
        public int Id { get; set; }
        public string musteriAdi { get; set; } = string.Empty;

        public int ServisId { get; set; }

        public int BerberId { get; set; }

        public DateTime RandevuTarihiVeSaati { get; set; }

        public musaitlik RandevuMusaitlik { get; set; }
    }
    public enum musaitlik
    {
        musait,
        musaitdegil,
        Beklemede
    }
}
