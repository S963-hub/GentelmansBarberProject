using GentelmansProject.Data;
using GentelmansProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GentelmansProject.Controllers
{
    public class KaydolVeGirisController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment environment;

        public KaydolVeGirisController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            this.context = context;
            this.environment = environment;
        }
        public IActionResult Create()
        {
            return View();
        }

        [Route("hello")]
        public IActionResult KullanciOlustur()
        {
            return View();
        }

        [HttpPost]
        [Route("hello")]
        public IActionResult KullanciOlustur(Kaydol kaydol)
        {
            if (!ModelState.IsValid)
            {
                return View(kaydol);
            }

            // Check for duplicate product names
            if (context.Kullancis.Any(p => p.Email == kaydol.Email))
            {
                ModelState.AddModelError("Name", "Bu Email Adresi daha önce Kayıt olmuştur.");
                return View(kaydol);
            }

            var kullanci = new Kullanci
            {
                Email = kaydol.Email,
                Password = kaydol.Password,
            };
            context.Kullancis.Add(kullanci);
            context.SaveChanges();


            return RedirectToAction("Index", "Giris");
        }
    }
}
