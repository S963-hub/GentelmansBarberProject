using GentelmansProject.Data;
using GentelmansProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GentelmansProject.Controllers
{
    [Authorize(Roles = "BERBER")]
    public class BerberController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public BerberController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Berberin tüm randevularını listeleme
        public async Task<IActionResult> OnayBekleyenRandevular()
        {
            var bekleyenRandevular = _context.Randevulars.Where(r => r.Onaylandi == false).ToList();
            return View(bekleyenRandevular);
        }


        // Randevuyu onaylama
        [HttpPost]
        public IActionResult Onayla(int id)
        {
            if (id == 0)
            {
                return BadRequest("Geçersiz ID");
            }

            var randevu = _context.Randevulars.FirstOrDefault(r => r.Id == id);
            if (randevu == null)
            {
                return NotFound("Randevu bulunamadı");
            }

            randevu.Onaylandi = true;
            _context.SaveChanges();

            return RedirectToAction("OnayBekleyenRandevular"); // burda Randevu onaylandi yazilsin
        }



        public IActionResult OnaylananRandevular()
        {
            // Onaylanan randevuları filtrele
            var onaylananRandevular = _context.Randevulars.Where(r => r.Onaylandi == true).ToList();
            return View(onaylananRandevular);
        }

        [HttpPost]
        public IActionResult Sil(int id)
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

            // Silme işleminden sonra aynı sayfaya yönlendirin
            return RedirectToAction("OnayBekleyenRandevular");
        }

    }
}
