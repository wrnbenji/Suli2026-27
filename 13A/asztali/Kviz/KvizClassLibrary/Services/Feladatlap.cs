namespace Kviz.Services;

public class Feladatlap : IFeladatlap
{
    Random rnd = new Random();
    KvizContext _context = new KvizContext();
    
    public ICollection<IgazHamisKerdes> getIgazHamisKerdes(int db)
    {
        List<IgazHamisKerdes> kivIgazHamisKerdes = new List<IgazHamisKerdes>();

        do
        {
            kivIgazHamisKerdes.Add(_context.IgazHamisKerdesek.ToList()[rnd.Next(0, _context.IgazHamisKerdesek.Count())]);
            
        }while(kivIgazHamisKerdes.Count < db);
        return kivIgazHamisKerdes;
    }

    public ICollection<IgazHamisKerdes> getIgazHamisKerdesTemakor(int db, string temakor)
    {
        List<IgazHamisKerdes> kivIgazHamisKerdes = new List<IgazHamisKerdes>();

        do
        {
            kivIgazHamisKerdes.Add(_context.IgazHamisKerdesek.Where(i =>i.Temakor == temakor).ToList()[rnd.Next(0, _context.IgazHamisKerdesek.Count())]);
            
        }while(kivIgazHamisKerdes.Count < db);
        return kivIgazHamisKerdes;
    }

    public ICollection<TippelosKerdes> getTippelosKerdes(int db)
    {
        List<TippelosKerdes> kivTippelosKerdes = new List<TippelosKerdes>();

        do
        {
            kivTippelosKerdes.Add(_context.TippelosKerdesek.ToList()[rnd.Next(0, _context.TippelosKerdesek.Count())]);
            
        }while(kivTippelosKerdes.Count < db);
        return kivTippelosKerdes;
    }

    public ICollection<TippelosKerdes> getTippelosKerdesTemakor(int db, string temakor)
    {
        List<TippelosKerdes> kivTippelosKerdes = new List<TippelosKerdes>();

        do
        {
            kivTippelosKerdes.Add(_context.TippelosKerdesek.Where(i =>i.Temakor == temakor).ToList()[rnd.Next(0, _context.TippelosKerdesek.Count())]);
            
        }while(kivTippelosKerdes.Count < db);
        return kivTippelosKerdes;
    }

    public ICollection<FelValKerdes> getFelValKerdes(int db)
    {
        List<FelValKerdes> kivFelValKerdes = new List<FelValKerdes>();

        do
        {
            kivFelValKerdes.Add(_context.FelValKerdesek.ToList()[rnd.Next(0, _context.FelValKerdesek.Count())]);
            
        }while(kivFelValKerdes.Count < db);
        return kivFelValKerdes;
    }
    

    public ICollection<FelValKerdes> getFelValKerdesTemakor(int db, string temakor)
    {
        List<FelValKerdes> kivFelValKerdes = new List<FelValKerdes>();

        do
        {
            kivFelValKerdes.Add(_context.FelValKerdesek.Where(i =>i.Temakor == temakor).ToList()[rnd.Next(0, _context.FelValKerdesek.Count())]);
            
        }while(kivFelValKerdes.Count < db);
        return kivFelValKerdes;
    }
}