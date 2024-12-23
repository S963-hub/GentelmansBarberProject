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
        public DbSet<Berber2> Berbers2 { get; set; }
        public DbSet<Berber3> Berbers3 { get; set; }
        public DbSet<Servis> Servises { get; set; }
        public DbSet<Servis2> Servises2 { get; set; }
        public DbSet<Servis3> Servises3 { get; set; }

        public DbSet<Randevular> Randevulars { get; set; }
        public DbSet<RandevularimViewModel> Randevularim { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("ADMIN") { NormalizedName = "ADMIN" };
            var berber = new IdentityRole("BERBER") { NormalizedName = "BERBER" };
            var kullanici = new IdentityRole("KULLANCI") { NormalizedName = "KULLANCI" };

            builder.Entity<IdentityRole>().HasData(admin, berber, kullanici);
        }

    }
}
