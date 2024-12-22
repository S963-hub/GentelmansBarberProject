using GentelmansProject.Data;
using GentelmansProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GentelmansProject.Controllers
{
    [Authorize]
    public class RandevuAlController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public RandevuAlController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Randevu Sayfası (Get)
        public async Task<IActionResult> RandevuAl()
        {
            var berberler = await _context.Berbers.ToListAsync();
            var servisler = await _context.Servises.ToListAsync();

            if (!berberler.Any())
            {
                ModelState.AddModelError("", "Henüz hiçbir berber eklenmemiş.");
            }

            if (!servisler.Any())
            {
                ModelState.AddModelError("", "Henüz hiçbir servis eklenmemiş.");
            }

            ViewBag.Berberler = berberler;
            ViewBag.Servisler = servisler;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RandevuAl(RandevuAlViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return Unauthorized();
                }
                var kullaniciId = user.Id;

                // Geçmiş tarihler kontrolü
                if (model.RandevuTarihi < DateTime.Today)
                {
                    ModelState.AddModelError("", "Geçmiş bir tarihe randevu alınamaz.");
                    return View(model);
                }

                // Seçilen saat dolu mu kontrol et
                bool isAvailable = !await _context.Randevulars
                    .AnyAsync(r => r.RandevuTarihi == model.RandevuTarihi
                                && r.RandevuSaati == model.RandevuSaati
                                && r.BerberId == model.BerberId);

                if (!isAvailable)
                {
                    ModelState.AddModelError("", "Seçilen saat başka bir kullanıcı tarafından alınmış.");
                    return View(model);
                }

                // Seçilen servislerin toplam fiyatını hesapla
                decimal toplamFiyat = 0;
                List<Servis> selectedServices = new List<Servis>();
                if (!string.IsNullOrEmpty(model.ServisIds))
                {
                    try
                    {
                        var servisIds = model.ServisIds
                            .Split(',')
                            .Where(id => !string.IsNullOrWhiteSpace(id))
                            .Select(int.Parse)
                            .ToList();

                        selectedServices = await _context.Servises
                            .Where(s => servisIds.Contains(s.Id))
                            .ToListAsync();

                        toplamFiyat = selectedServices.Sum(s => s.HizmetFiyat);

                        // Seçilen servisleri ve toplam fiyatı ViewBag içinde sakla
                        ViewBag.SelectedServices = selectedServices;
                        ViewBag.ToplamFiyat = toplamFiyat;
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "Servis fiyatları hesaplanırken bir hata oluştu: " + ex.Message);
                        return View(model);
                    }
                }

                model.ToplamFiyat = toplamFiyat;

                // Randevuyu oluştur ve kaydet
                var randevu = new Randevular
                {
                    KullaniciId = kullaniciId,
                    BerberId = model.BerberId,
                    ServisIds = model.ServisIds,
                    RandevuTarihi = model.RandevuTarihi,
                    RandevuSaati = model.RandevuSaati,
                    ToplamFiyat = model.ToplamFiyat,
                    Notlar = string.IsNullOrWhiteSpace(model.Notlar) ? null : model.Notlar
                };

                _context.Randevulars.Add(randevu);
                await _context.SaveChangesAsync();

                return RedirectToAction("Randevularim");
            }

            // ViewBag için gerekli verileri tekrar yükleyin
            ViewBag.Berberler = await _context.Berbers.ToListAsync();
            ViewBag.Servisler = await _context.Servises.ToListAsync();

            return View(model);
        }

        // Kullanıcının randevularını listeleme
        public async Task<IActionResult> Randevularim()
        {
            // Giriş yapan kullanıcı kimliği
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized(); // Kullanıcı giriş yapmamış
            }

            var userId = user.Id; // Kullanıcı ID'sini al
            var randevular = await _context.Randevulars
                .Include(r => r.Berber) // Berber tablosunu ekliyoruz
                .Where(r => r.KullaniciId == userId) // Kullanıcı ID'sine göre filtreleme
                .ToListAsync();

            return View(randevular); // Model'i View'e gönderiyoruz
        }
    }
}
