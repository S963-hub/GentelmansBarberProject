using System.Net.Http.Headers;
using Microsoft.Extensions.Logging;

public class HairstyleService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    private readonly ILogger<HairstyleService> _logger;

    public HairstyleService(HttpClient httpClient, IConfiguration configuration, ILogger<HairstyleService> logger)
    {
        _httpClient = httpClient;
        _configuration = configuration;
        _logger = logger;

        // API temel ayarları
        _httpClient.BaseAddress = new Uri(_configuration["APISettings:BaseUrl"]);
        _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _configuration["APISettings:RapidAPIKey"]);
        _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", _configuration["APISettings:RapidAPIHost"]);
    }

    public async Task<string> UploadPhotoAsync(Stream photoStream, string fileName)
    {
        using (var content = new MultipartFormDataContent())
        {
            // Fotoğraf içeriği
            var fileContent = new StreamContent(photoStream);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
            content.Add(fileContent, "image", fileName); // Alan adını API'ye göre ayarlayın

            try
            {
                _logger.LogInformation("Hairstyle API'ye istek gönderiliyor.");
                // API çağrısını gerçekleştir
                var response = await _httpClient.PostAsync("/change-hairstyle", content); // Doğru endpointi kullanın

                // Hata varsa fırlat
                response.EnsureSuccessStatusCode();

                _logger.LogInformation("Hairstyle API'den başarılı yanıt alındı.");
                // Yanıtı string olarak döndür
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "HTTP isteği sırasında bir hata oluştu.");
                if (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    throw new Exception("API endpoint bulunamadı. Endpoint yolunu kontrol edin.");
                }
                throw new Exception($"Bir HTTP hatası oluştu: {ex.Message}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Genel bir hata oluştu.");
                throw new Exception($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
