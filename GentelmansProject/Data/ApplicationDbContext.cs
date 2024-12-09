using GentelmansProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GentelmansProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Berber> Berbers { get; set; }
        public DbSet<Kullancilar> Kullancilars { get; set; }
        public DbSet<Servis> Servises { get; set; }
        public DbSet<Randevular> Randevulars { get; set; }

    }
}
