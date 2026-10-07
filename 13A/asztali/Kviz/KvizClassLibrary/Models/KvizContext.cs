using Microsoft.EntityFrameworkCore;

namespace Kviz;

public class KvizContext : DbContext
{
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connection = "Server=localhost;Database=kviz;Uid=root;Pwd=root;";
        optionsBuilder.UseMySql(connection , ServerVersion.AutoDetect(connection));
    }

    public DbSet<FelValKerdes> FelValKerdesek { get; set; }
    public DbSet<IgazHamisKerdes> IgazHamisKerdesek { get; set; }
    public DbSet<TippelosKerdes>  TippelosKerdesek { get; set; }
}