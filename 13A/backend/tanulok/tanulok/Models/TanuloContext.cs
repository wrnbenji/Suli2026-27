using Microsoft.EntityFrameworkCore;

namespace tanulok.Models
{
    public class TanuloContext : DbContext
    {
       


        public DbSet<Tanulo> Tanulok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Server=localhost;Database=Tanulohianyzasok;Uid=root;Pwd=root;";

            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));

        }

    
        
    }
}
