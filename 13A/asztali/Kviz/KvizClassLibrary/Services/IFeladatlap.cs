using Kviz.Interface;

namespace Kviz.Services;

public interface IFeladatlap
{
    ICollection<Kerdes> getIgazHamisKerdes(int db);
    ICollection<Kerdes> getIgazHamisKerdesTemakor(int db, string temakor);
    
    ICollection<Kerdes> getTippelosKerdes(int db);
    ICollection<Kerdes> getTippelosKerdesTemakor(int db, string temakor);

    ICollection<Kerdes> getFelValKerdes(int db);
    ICollection<Kerdes> getFelValKerdesTemakor(int db, string temakor);

    ICollection<Kerdes> getVegyesKerdes(int db);
    
}