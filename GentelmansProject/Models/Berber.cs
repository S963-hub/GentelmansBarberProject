namespace GentelmansProject.Models
{
    public class Berber
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string UzmanlikAlani { get; set; } = string.Empty;

        public musaitlikDurumu musaitlik { get; set; }

    }
    public enum musaitlikDurumu
    {
        musait,
        musaitdegil
    }

    /*    AvailabilityStatus status = AvailabilityStatus.musait;

// Durumu kontrol et
if (status == AvailabilityStatus.musait)
{
    Console.WriteLine("Çalışan müsait.");
}
else
{
    Console.WriteLine("Çalışan müsait değil.");
}*/
}
