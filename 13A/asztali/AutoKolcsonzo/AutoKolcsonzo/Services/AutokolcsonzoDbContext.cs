using AutoKolcsonzoLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsonzo.Services
{
    public class AutokolcsonzoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string c = "Server=localhost;Database=autokolcsonzo_gyakorlat;Uid=root;Pwd=root;";

            optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>()
                .HasOne(a => a.Gyarto)
                .WithMany(b=> b.Autok)
                .HasForeignKey(a => a.GyartoId);

            modelBuilder.Entity<Auto>()
                .HasOne(a => a.Kategoria)
                .WithMany(b=> b.Autok)
                .HasForeignKey(a => a.KategoriaId);

            modelBuilder.Entity<Berles>()
                .HasOne(a => a.Ugyfel)
                .WithMany(b => b.Berlesek)
                .HasForeignKey(a => a.UgyfelId);

            modelBuilder.Entity<Berles>()
                .HasOne(a => a.Auto)
                .WithMany(b => b.Berlesek)
                .HasForeignKey(a => a.AutoId);



            modelBuilder.Entity<Auto>().ToTable("Autok");
            modelBuilder.Entity<Berles>().ToTable("Berlesek");
            modelBuilder.Entity<Gyarto>().ToTable("Gyartok");
            modelBuilder.Entity<Kategoria>().ToTable("Kategoriak");
            modelBuilder.Entity<Ugyfel>().ToTable("Ugyfelek");
        }

        public DbSet<Auto> Autok {  get; set; }
        public DbSet<Berles> Berlesek { get; set; }
        public DbSet<Gyarto> Gyartok { get; set; }

        public DbSet<Kategoria> Kategoriak { get; set; }
        public DbSet<Ugyfel> Ugyfel { get; set; }
    }
}
