using GentelmansProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GentelmansProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Berber> Berbers { get; set; }
        public DbSet<Kullanci> Kullancis { get; set; }
        public DbSet<Servis> Servises { get; set; }
        public DbSet<Randevular> Randevulars { get; set; }
        public DbSet<GentelmansProject.Models.Kaydol>? Kaydol { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "ADMIN";

            var Berber = new IdentityRole("Berber");
            Berber.NormalizedName = "BERBER";

            var Kullanci = new IdentityRole("Kullanci");
            Kullanci.NormalizedName = "kULLANCI";

            builder.Entity<IdentityRole>().HasData(admin, Berber, Kullanci);
        }


    }
}
