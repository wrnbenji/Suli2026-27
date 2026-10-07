namespace Kviz.Services;

public interface IFeladatlap
{
    ICollection<IgazHamisKerdes> getIgazHamisKerdes(int db);
    ICollection<IgazHamisKerdes> getIgazHamisKerdesTemakor(int db, string temakor);
    
    ICollection<TippelosKerdes> getTippelosKerdes(int db);
    ICollection<TippelosKerdes> getTippelosKerdesTemakor(int db, string temakor);

    ICollection<FelValKerdes> getFelValKerdes(int db);
    ICollection<FelValKerdes> getFelValKerdesTemakor(int db, string temakor);

    
}