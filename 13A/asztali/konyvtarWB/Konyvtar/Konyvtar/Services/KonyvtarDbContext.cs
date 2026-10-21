using KonyvtarLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarLibrary.Services
{
    internal class KonyvtarDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            
        {
            string connection = "Server=localhost;Database=konyvtar_gyakorlat;Uid=root;Pwd=root;";
            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }
        public DbSet<Kategoria> Kategoriak { get; set; }
        public DbSet<Kolcsonzes> Kolcsonzesek { get; set; }
        public DbSet<Konyv> Konyvek { get; set; }
        public DbSet<Olvaso> Olvasok { get; set; }
        public DbSet<Szerzo> Szerzo { get; set; }
    }
}
