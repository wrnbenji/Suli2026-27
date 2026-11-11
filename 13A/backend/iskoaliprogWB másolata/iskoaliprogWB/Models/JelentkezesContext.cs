using Microsoft.EntityFrameworkCore;

namespace iskoaliprogWB.Models
{
    public class JelentkezesContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string c = "Server=localhost;Database=JelentkezesWB;Uid=root;Pwd=root;";

            optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));
        }

        public DbSet<Jelentkezes> jelentkezesek { get; set; }
    }
}
