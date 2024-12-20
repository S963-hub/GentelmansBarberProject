using GentelmansProject.Data;
using GentelmansProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;
using System.Text;

namespace GentelmansProject.Controllers
{/*
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
        public IActionResult Name(ApplicationUser kaydol)
        {
            if (context.Kullancis.Any(p => p.Email == kaydol.Email))
            {
                ViewData["Name"] = kaydol.FullName;
                return View(kaydol);
            }
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
    */
    }





/*@model GentelmansProject.Models.Kaydol

@{
    Layout = "_Layout";
}


<!DOCTYPE html>
<!-- Coding by CodingNepal | www.codingnepalweb.com-->
<html lang="en" dir="ltr">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="css/KullanciOlustur.css">
    <!-- Fontawesome CDN Link -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css">
</head>
<body>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validation/1.19.3/jquery.validate.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.11/jquery.validate.unobtrusive.min.js"></script>



    <div class="container">
        <input type="checkbox" id="flip">
        <div class="cover">
            <div class="front">
                <div class="text">
                    <span class="text-1">Every new friend is a <br> new adventure</span>
                    <span class="text-2">Let's get connected</span>
                </div>
            </div>
            <div class="back">
                <img class="backImg" src="images/picture1.jpg" alt="">
 
            </div>
        </div>
        <div class="forms">
            <div class="form-content">


                <div class="signup-form">
                    <div class="title">Hesap Oluşturunuz</div>
                    <form asp-controller="KaydolVeGiris" asp-action="KullanciOlustur" method="post">
                        <div class="input-box">
                            <i class="fas fa-user"></i>
                            <input asp-for="Name" class="form-control" placeholder="Ad" />
                            <span asp-validation-for="Name" class="text-danger"></span>
                        </div>
                        <div class="input-box">
                            <i class="fas fa-envelope"></i>
                            <input asp-for="Email" class="form-control" placeholder="Email" />
                            <span asp-validation-for="Email" class="text-danger"></span>
                        </div>
                        <div class="input-box">
                            <i class="fas fa-lock"></i>
                            <input asp-for="Password" type="password" class="form-control" placeholder="Şifre" />
                            <span asp-validation-for="Password" class="text-danger"></span>
                        </div>
                        <div class="input-box">
                            <i class="fas fa-lock"></i>
                            <input asp-for="ConfirmPassword" type="password" class="form-control" placeholder="Şifreyi Tekrar giriniz" />
                            <span asp-validation-for="ConfirmPassword" class="text-danger"></span>
                        </div>
                        <div class="button input-box">
                            <input type="submit" value="Kaydol">
                        </div>
                    </form>
                    <div class="text sign-up-text">Hesabınız var mı? <a href="/KaydolVeGiris/Giris">Giriş Yap</a></div>

                </div>


            </div>
        </div>
    </div>

</body>
</html>






*/






















