using GentelmansProject.Data;
using GentelmansProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [HttpGet]
        public async Task<IActionResult> RandevuAl()
        {
            ViewBag.SalonId = null;
            var salonlar = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Salon 1" },
                new SelectListItem { Value = "2", Text = "Salon 2" },
                new SelectListItem { Value = "3", Text = "Salon 3" }
            };
            ViewBag.Salonlar = salonlar;

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SalonSecim(int salonSecimi)
        {
            ViewBag.SalonId = salonSecimi;
            await LoadViewBagData(salonSecimi);

            var model = new RandevuAlViewModel();
            model.SalonId = salonSecimi;

            return View("RandevuAl", model);
        }


        [HttpPost]
        public async Task<IActionResult> RandevuAl(RandevuAlViewModel model)
        {
            int salonSecimi = model.SalonId;
            ViewBag.SalonId = salonSecimi;

            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return Unauthorized();
                }
                var kullaniciId = user.Id;

                if (model.RandevuTarihi < DateTime.Today)
                {
                    ModelState.AddModelError("", "Geçmiş bir tarihe randevu alınamaz.");
                    await LoadViewBagData(salonSecimi);
                    return RedirectToAction("RandevuAl");
                }

                bool isAvailable = !await _context.Randevulars
                    .AnyAsync(r => r.RandevuTarihi == model.RandevuTarihi
                                && r.RandevuSaati == model.RandevuSaati
                                && r.BerberId == model.BerberId);


                if (!isAvailable)
                {
                    ViewBag.Message = "Seçilen saat başka bir kullanıcı tarafından alınmış. Lütfen Randevu Al sayfasina Tekrar Dönünüz.";
                    //await LoadViewBagData(salonSecimi);
                    return View(model);
                }

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
            else
            {
                ModelState.AddModelError("", "Not kismi bos olamaz.");

            }
            await LoadViewBagData(salonSecimi);
            return View(model);
        }

        private async Task LoadViewBagData(int salonSecimi)
        {
            if (salonSecimi == 1)
            {
                ViewBag.Berberler = await _context.Berbers.ToListAsync();
                ViewBag.Servisler = await _context.Servises.ToListAsync();
            }
            else if (salonSecimi == 2)
            {
                ViewBag.Berberler = await _context.Berbers2.ToListAsync();
                ViewBag.Servisler = await _context.Servises2.ToListAsync();
            }
            else if (salonSecimi == 3)
            {
                ViewBag.Berberler = await _context.Berbers3.ToListAsync();
                ViewBag.Servisler = await _context.Servises3.ToListAsync();
            }
            else
            {
                ViewBag.Berberler = new List<Berber>();
                ViewBag.Servisler = new List<Servis>();
            }
            ViewBag.Salonlar = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Salon 1" },
                new SelectListItem { Value = "2", Text = "Salon 2" },
                new SelectListItem { Value = "3", Text = "Salon 3" }
            };
        }

        public async Task<IActionResult> Randevularim()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized(); 
            }

            var userId = user.Id; 
            var randevular = await _context.Randevulars
                .Include(r => r.Berber) 
                .Where(r => r.KullaniciId == userId) 
                .ToListAsync();

            return View(randevular); 
        }

        [HttpPost]
        public IActionResult RandevuSil(int id)
        {
            if (id == 0)
            {
                return BadRequest("Geçersiz ID");
            }

            var randevu = _context.Randevulars.FirstOrDefault(r => r.Id == id);
            if (randevu == null)
            {
                return NotFound("Randevu bulunamadı.");
            }

            _context.Randevulars.Remove(randevu);
            _context.SaveChanges();

            return RedirectToAction("Randevularim");
        }



    }
}
