using Microsoft.EntityFrameworkCore;

namespace Mozi.Models
{
    public class FilmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Server=localhost;Database=MoziFilmek;Uid=root;Pwd=root;";

            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmMufaj>().HasKey(fm => new { fm.FilmId, fm.MufajId });
        }

         public DbSet<Film> filmek {  get; set; }
        public DbSet<Kiado> kidadok { get; set; }
        public DbSet<Mufaj> mufajok { get; set; }
    }
}
