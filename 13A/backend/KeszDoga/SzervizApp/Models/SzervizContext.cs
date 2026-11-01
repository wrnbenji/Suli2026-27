using Microsoft.EntityFrameworkCore;

namespace SzervizApp.Models
{
    public class SzervizContext : DbContext
    {
        public SzervizContext(DbContextOptions<SzervizContext> options) : base(options)
        {
        }

        public DbSet<Bejelentes> Bejelentesek { get; set; }
    }
}
