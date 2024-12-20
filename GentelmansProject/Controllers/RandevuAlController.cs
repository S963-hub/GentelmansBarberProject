using GentelmansProject.Data;
using GentelmansProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GentelmansProject.Controllers
{
    [Authorize]
    public class RandevuAlController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RandevuAlController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Randevu Sayfası (Get)
        public async Task<IActionResult> RandevuAl()
        {
            ViewBag.Berberler = _context.Berbers.ToList();
            ViewBag.Servisler = _context.Servises.ToList();

            // Breakpoint koyarak ViewBag.Berberler'in dolu olup olmadığını kontrol edin
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RandevuAl(RandevuAlViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Seçilen saat dolu mu kontrol et
                bool isAvailable = !_context.Randevulars
                    .Any(r => r.RandevuTarihi == model.RandevuTarihi && r.RandevuSaati == model.RandevuSaati && r.BerberId == model.BerberId);

                if (!isAvailable)
                {
                    ModelState.AddModelError("", "Seçilen saat başka bir kullanıcı tarafından alınmış.");
                    return View(model);
                }

                // Seçilen servislerin toplam fiyatını hesapla
                var servisIds = model.ServisIds.Split(',').Select(int.Parse).ToList();
               // decimal toplamFiyat = servisIds.Sum(id => _context.Servises.Find(id)?.ToplamFiyat ?? 0);

                // Randevuyu oluştur ve kaydet
                var randevu = new Randevular
                {
                    KullaniciId = User.Identity.Name,
                    BerberId = model.BerberId,
                    ServisIds = model.ServisIds,
                    RandevuTarihi = model.RandevuTarihi,
                    RandevuSaati = model.RandevuSaati,
                    //ToplamFiyat = toplamFiyat,
                    Notlar = model.Notlar
                };

                _context.Randevulars.Add(randevu);
                _context.SaveChanges();

                return RedirectToAction("Randevularim");
            }

            return View(model);
        }





        // Kullanıcının randevularını listeleme
        public IActionResult Randevularim()
        {
            var userId = User.Identity.Name; // Şu anki kullanıcı ID'si
            var randevular = _context.Randevulars
                .Include(r => r.Berber)
                .Where(r => r.KullaniciId == userId)
                .ToList();

            return View(randevular);
        }
    }
}











/*

public async Task<IActionResult> Randevularim()
        {
            var user = await _userManager.GetUserAsync(User);
            var randevular = _context.Randevulars
                .Where(r => r.UserId == user.Id) // Yalnızca giriş yapan kullanıcının randevuları
                .ToList();

            return View(randevular);
        }*/