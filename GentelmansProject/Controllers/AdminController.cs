using GentelmansProject.Models;
using GentelmansProject.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GentelmansProject.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult AdminDashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.SalonId = null;
            return View("AdminDashboard");
        }

        [HttpPost]
        public IActionResult Index(Char salonSecimi)
        {
            ViewBag.SalonId = salonSecimi;
            return View("AdminDashboard");
        }

        public async Task<IActionResult> CalisanListesi(Char salonId)
        {
            ViewBag.SalonId = salonId;
            IEnumerable<Berber> calisanlar;
            switch (salonId)
            {
                case '1':
                    calisanlar = await _context.Berbers.ToListAsync();
                    break;
                case '2':
                    calisanlar = (await _context.Berbers2.ToListAsync()).Select(c => new Berber
                    {
                        Id = c.Id,
                        Name = c.Name,
                        UzmanlikAlani = c.UzmanlikAlani
                    });
                    break;
                case '3':
                    calisanlar = (await _context.Berbers3.ToListAsync()).Select(c => new Berber
                    {
                        Id = c.Id,
                        Name = c.Name,
                        UzmanlikAlani = c.UzmanlikAlani
                    });
                    break;
                default:
                    calisanlar = Enumerable.Empty<Berber>();
                    break;
            }
            return View(calisanlar);
        }

        public async Task<IActionResult> ServisleriYonet(Char salonId)
        {
            ViewBag.SalonId = salonId;
            IEnumerable<Servis> servisler;
            switch (salonId)
            {
                case '1':
                    servisler = await _context.Servises.ToListAsync();
                    break;
                case '2':
                    servisler = (await _context.Servises2.ToListAsync()).Select(s => new Servis
                    {
                        Id = s.Id, 
                        Name = s.Name,
                        HizmetSuresi = s.HizmetSuresi,
                        HizmetFiyat = s.HizmetFiyat
                    });
                    break;
                case '3':
                    servisler = (await _context.Servises3.ToListAsync()).Select(s => new Servis
                    {
                        Id = s.Id,
                        Name = s.Name,
                        HizmetSuresi = s.HizmetSuresi,
                        HizmetFiyat = s.HizmetFiyat
                    });
                    break;
                default:
                    servisler = Enumerable.Empty<Servis>();
                    break;
            }
            return View(servisler);
        }



        [HttpGet]
        public IActionResult CalisanEkleGuncelle(int? id, char salonId)
        {
            ViewBag.SalonId = salonId;
            if (id == null)
            {
                return View(new BerberViewModel());
            }
            else
            {
                Berber calisan = null;
                switch (salonId)
                {
                    case '1':
                        calisan = _context.Berbers.Find(id);
                        break;
                    case '2':
                        var berber2 = _context.Berbers2.Find(id);
                        if (berber2 != null)
                        {
                            calisan = new Berber
                            {
                                Id = berber2.Id,
                                Name = berber2.Name,
                                UzmanlikAlani = berber2.UzmanlikAlani
                            };
                        }
                        break;
                    case '3':
                        var berber3 = _context.Berbers3.Find(id);
                        if (berber3 != null)
                        {
                            calisan = new Berber
                            {
                                Id = berber3.Id,
                                Name = berber3.Name,
                                UzmanlikAlani = berber3.UzmanlikAlani
                            };
                        }
                        break;
                }
                if (calisan == null)
                {
                    return NotFound();
                }
                var viewModel = new BerberViewModel
                {
                    Id = calisan.Id,
                    Name = calisan.Name,
                    UzmanlikAlani = calisan.UzmanlikAlani
                };
                return View(viewModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CalisanEkleGuncelle(BerberViewModel model, Char salonId)
        {
            if (ModelState.IsValid)
            {
                switch (salonId)
                {
                    case '1':
                        var calisan1 = new Berber
                        {
                            Id = model.Id,
                            Name = model.Name,
                            UzmanlikAlani = model.UzmanlikAlani
                        };
                        if (model.Id == 0)
                        {
                            _context.Berbers.Add(calisan1);
                        }
                        else
                        {
                            _context.Berbers.Update(calisan1);
                        }
                        break;
                    case '2':
                        var calisan2 = new Berber2
                        {
                            Id = model.Id,
                            Name = model.Name,
                            UzmanlikAlani = model.UzmanlikAlani
                        };
                        if (model.Id == 0)
                        {
                            _context.Berbers2.Add(calisan2);
                        }
                        else
                        {
                            _context.Berbers2.Update(calisan2);
                        }
                        break;
                    case '3':
                        var calisan3 = new Berber3
                        {
                            Id = model.Id,
                            Name = model.Name,
                            UzmanlikAlani = model.UzmanlikAlani
                        };
                        if (model.Id == 0)
                        {
                            _context.Berbers3.Add(calisan3);
                        }
                        else
                        {
                            _context.Berbers3.Update(calisan3);
                        }
                        break;
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("CalisanListesi", new { salonId = salonId });
            }
            return View(model);
        }

        public async Task<IActionResult> CalisanSil(int id, char salonId)
        {
            Berber calisan = null;
            switch (salonId)
            {
                case '1':
                    calisan = await _context.Berbers.FindAsync(id);
                    break;
                case '2':
                    var berber2 = await _context.Berbers2.FindAsync(id);
                    if (berber2 != null)
                    {
                        calisan = new Berber
                        {
                            Id = berber2.Id,
                            Name = berber2.Name,
                            UzmanlikAlani = berber2.UzmanlikAlani
                        };
                    }
                    break;
                case '3':
                    var berber3 = await _context.Berbers3.FindAsync(id);
                    if (berber3 != null)
                    {
                        calisan = new Berber
                        {
                            Id = berber3.Id,
                            Name = berber3.Name,
                            UzmanlikAlani = berber3.UzmanlikAlani
                        };
                    }
                    break;
            }
            if (calisan == null)
            {
                return NotFound();
            }
            switch (salonId)
            {
                case '1':
                    _context.Berbers.Remove(calisan);
                    break;
                case '2':
                    _context.Berbers2.Remove(await _context.Berbers2.FindAsync(id));
                    break;
                case '3':
                    _context.Berbers3.Remove(await _context.Berbers3.FindAsync(id));
                    break;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("CalisanListesi", new { salonId = salonId });
        }
        [HttpGet]
        public IActionResult ServisEkleGuncelle(int? id, Char salonId)
        {
            ViewBag.SalonId = salonId;
            if (id == null)
            {
                return View(new ServisViewModel());
            }
            else
            {
                Servis servis = null;
                switch (salonId)
                {
                    case '1':
                        servis = _context.Servises.Find(id);
                        break;
                    case '2':
                        var servis2 = _context.Servises2.Find(id);
                        if (servis2 != null)
                        {
                            servis = new Servis
                            {
                                Id = servis2.Id,
                                Name = servis2.Name,
                                HizmetSuresi = servis2.HizmetSuresi,
                                HizmetFiyat = servis2.HizmetFiyat
                            };
                        }
                        break;
                    case '3':
                        var servis3 = _context.Servises3.Find(id);
                        if (servis3 != null)
                        {
                            servis = new Servis
                            {
                                Id = servis3.Id,
                                Name = servis3.Name,
                                HizmetSuresi = servis3.HizmetSuresi,
                                HizmetFiyat = servis3.HizmetFiyat
                            };
                        }
                        break;
                }
                if (servis == null)
                {
                    return NotFound();
                }
                var viewModel = new ServisViewModel
                {
                    Id = servis.Id,
                    Name = servis.Name,
                    HizmetSuresi = servis.HizmetSuresi,
                    HizmetFiyat = servis.HizmetFiyat
                };
                return View(viewModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ServisEkleGuncelle(ServisViewModel model, Char salonId)
        {
            if (ModelState.IsValid)
            {
                switch (salonId)
                {
                    case '1':
                        var servis1 = new Servis
                        {
                            Id = model.Id,
                            Name = model.Name,
                            HizmetSuresi = model.HizmetSuresi,
                            HizmetFiyat = model.HizmetFiyat
                        };
                        if (model.Id == 0)
                        {
                            _context.Servises.Add(servis1);
                        }
                        else
                        {
                            _context.Servises.Update(servis1);
                        }
                        break;
                    case '2':
                        var servis2 = new Servis2
                        {
                            Id = model.Id,
                            Name = model.Name,
                            HizmetSuresi = model.HizmetSuresi,
                            HizmetFiyat = model.HizmetFiyat
                        };
                        if (model.Id == 0)
                        {
                            _context.Servises2.Add(servis2);
                        }
                        else
                        {
                            _context.Servises2.Update(servis2);
                        }
                        break;
                    case '3':
                        var servis3 = new Servis3
                        {
                            Id = model.Id,
                            Name = model.Name,
                            HizmetSuresi = model.HizmetSuresi,
                            HizmetFiyat = model.HizmetFiyat
                        };
                        if (model.Id == 0)
                        {
                            _context.Servises3.Add(servis3);
                        }
                        else
                        {
                            _context.Servises3.Update(servis3);
                        }
                        break;
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("ServisleriYonet", new { salonId = salonId });
            }
            return View(model);
        }

        public async Task<IActionResult> ServisSil(int id, char salonId)
        {
            Servis servis = null;
            switch (salonId)
            {
                case '1':
                    servis = await _context.Servises.FindAsync(id);
                    break;
                case '2':
                    var servis2 = await _context.Servises2.FindAsync(id);
                    if (servis2 != null)
                    {
                        servis = new Servis
                        {
                            Id = servis2.Id,
                            Name = servis2.Name,
                            HizmetSuresi = servis2.HizmetSuresi,
                            HizmetFiyat = servis2.HizmetFiyat
                        };
                    }
                    break;
                case '3':
                    var servis3 = await _context.Servises3.FindAsync(id);
                    if (servis3 != null)
                    {
                        servis = new Servis
                        {
                            Id = servis3.Id,
                            Name = servis3.Name,
                            HizmetSuresi = servis3.HizmetSuresi,
                            HizmetFiyat = servis3.HizmetFiyat
                        };
                    }
                    break;
            }
            if (servis == null)
            {
                return NotFound();
            }
            switch (salonId)
            {
                case '1':
                    _context.Servises.Remove(servis);
                    break;
                case '2':
                    _context.Servises2.Remove(await _context.Servises2.FindAsync(id));
                    break;
                case '3':
                    _context.Servises3.Remove(await _context.Servises3.FindAsync(id));
                    break;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("ServisleriYonet", new { salonId = salonId });
        }
    }
}
