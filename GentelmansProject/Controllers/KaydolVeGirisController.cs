using GentelmansProject.Data;
using GentelmansProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;
using System.Text;

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
                Name = kaydol.Name,
                Email = kaydol.Email,
                Password = kaydol.Password,
            };
            context.Kullancis.Add(kullanci);
            context.SaveChanges();


            return RedirectToAction("Giris", "KaydolVeGiris");
        }

            public IActionResult Giris()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Giris(int id, Giris G)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var user = context.Kullancis.FirstOrDefault(p => p.Email == G.Email);
                if (user == null)
                {
                    ModelState.AddModelError("Email", "Bu Email adresi için hesap oluşturulmamıştır.");
                    return View(G);
                }

                 
                return Content("Giris yapildi");
            }

        }
    }























