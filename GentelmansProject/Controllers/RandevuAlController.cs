using GentelmansProject.Data;
using GentelmansProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

        public async Task<IActionResult> RandevuAlAsync()
        {
            var user = _userManager.GetUserAsync(User).Result;

            // Servis ve Kuaför verilerini alıyoruz
            var kuaforler = await _context.Berbers.ToListAsync();
            var servisler = await _context.Servises.ToListAsync();

            var model = new RandevuAl
            {
                Kuaforler = kuaforler,
                Servisler = servisler
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RandevuAl(RandevuAl model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);

                // Seçilen servislerin süre ve ücretlerini hesaplıyoruz
                var servisler = _context.Servises
                    .Where(s => model.SecilenServisIds.Contains(s.Id))
                    .ToList();

                var toplamSure = servisler.Sum(s => s.Sure);
                var toplamUcret = servisler.Sum(s => s.Ucret);

                var randevu = new Randevular
                {
                    MusteriAdi = user.UserName,
                    CalisanAdi = model.CalisanAdi,
                    Ucret = toplamUcret,
                    Sure = toplamSure,
                    RandevuTarihi = model.RandevuTarihi,
                    OnayDurumu = model.OnayDurumu,
                    UserId = user.Id
                };

                _context.Randevulars.Add(randevu);
                await _context.SaveChangesAsync();

                TempData["Message"] = "Randevunuz başarıyla oluşturuldu!";
                return RedirectToAction("Randevularim");
            }

            return View(model);
        }


        public async Task<IActionResult> Randevularim()
        {
            var user = await _userManager.GetUserAsync(User);
            var randevular = _context.Randevulars
                .Where(r => r.UserId == user.Id) // Yalnızca giriş yapan kullanıcının randevuları
                .ToList();

            return View(randevular);
        }
    }
}
