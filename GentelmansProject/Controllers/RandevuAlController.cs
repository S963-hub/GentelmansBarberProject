using Microsoft.AspNetCore.Mvc;
using GentelmansProject.Models;
using GentelmansProject.Data;

namespace GentelmansProject.Controllers
{
    public class RandevuAlController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment environment;

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(RandevuAl randevual)
        {
            if (productDto.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "Image file must not be empty.");
            }

            if (!ModelState.IsValid)
            {
                return View(productDto);
            }

            // Check for duplicate product names
            if (context.Products.Any(p => p.Name == productDto.Name))
            {
                ModelState.AddModelError("Name", "A product with the same name already exists.");
                return View(productDto);
            }

            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + Path.GetExtension(productDto.ImageFile.FileName);
            string productFolder = Path.Combine(environment.WebRootPath, "products");

            if (!Directory.Exists(productFolder))
            {
                Directory.CreateDirectory(productFolder);
            }

            string imageFullPath = Path.Combine(productFolder, newFileName);

            using (var stream = System.IO.File.Create(imageFullPath))
            {
                productDto.ImageFile.CopyTo(stream);
            }

            var product = new Product
            {
                Name = productDto.Name,
                Brand = productDto.Brand,
                Category = productDto.Category,
                Description = productDto.Description,
                ImageFileName = newFileName,
                CreatedAt = DateTime.UtcNow
            };

            context.Products.Add(product);
            context.SaveChanges();


            return RedirectToAction("Index", "Product");
        }
    }
}
