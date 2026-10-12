using Microsoft.EntityFrameworkCore;

namespace Dolgozatwb.Models
{
    public class BejelentoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string c = "Server=localhost;Database=szervizdb;Uid=root;Pwd=root;";
            optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));

        }

        public DbSet<Bejelentes> bejeletesek { get; set;}

    }

}
