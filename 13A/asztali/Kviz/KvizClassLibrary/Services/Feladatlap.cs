using Kviz.Interface;

namespace Kviz.Services;

public class Feladatlap : IFeladatlap
{
    Random rnd = new Random();
    KvizContext _context = new KvizContext();
    
    public ICollection<Kerdes> getIgazHamisKerdes(int db)
    {
        List<Kerdes> kivIgazHamisKerdes = new List<Kerdes>();

        do
        {
            kivIgazHamisKerdes.Add(_context.IgazHamisKerdesek.ToList()[rnd.Next(0, _context.IgazHamisKerdesek.Count())]);
            
        }while(kivIgazHamisKerdes.Count < db);
        return kivIgazHamisKerdes;
    }

    public ICollection<Kerdes> getIgazHamisKerdesTemakor(int db, string temakor)
    {
        List<Kerdes> kivIgazHamisKerdes = new List<Kerdes>();

        do
        {
            kivIgazHamisKerdes.Add(_context.IgazHamisKerdesek.Where(i =>i.Temakor == temakor).ToList()[rnd.Next(0, _context.IgazHamisKerdesek.Count())]);
            
        }while(kivIgazHamisKerdes.Count < db);
        return kivIgazHamisKerdes;
    }

    public ICollection<Kerdes> getTippelosKerdes(int db)
    {
        List<Kerdes> kivTippelosKerdes = new List<Kerdes>();

        do
        {
            kivTippelosKerdes.Add(_context.TippelosKerdesek.ToList()[rnd.Next(0, _context.TippelosKerdesek.Count())]);
            
        }while(kivTippelosKerdes.Count < db);
        return kivTippelosKerdes;
    }

    public ICollection<Kerdes> getTippelosKerdesTemakor(int db, string temakor)
    {
        List<Kerdes> kivTippelosKerdes = new List<Kerdes>();

        do
        {
            kivTippelosKerdes.Add(_context.TippelosKerdesek.Where(i =>i.Temakor == temakor).ToList()[rnd.Next(0, _context.TippelosKerdesek.Count())]);
            
        }while(kivTippelosKerdes.Count < db);
        return kivTippelosKerdes;
    }

    public ICollection<Kerdes> getFelValKerdes(int db)
    {
        List<Kerdes> kivFelValKerdes = new List<Kerdes>();

        do
        {
            kivFelValKerdes.Add(_context.FelValKerdesek.ToList()[rnd.Next(0, _context.FelValKerdesek.Count())]);
            
        }while(kivFelValKerdes.Count < db);
        return kivFelValKerdes;
    }
    

    public ICollection<Kerdes> getFelValKerdesTemakor(int db, string temakor)
    {
        List<Kerdes> kivFelValKerdes = new List<Kerdes>();

        do
        {
            kivFelValKerdes.Add(_context.FelValKerdesek.Where(i =>i.Temakor == temakor).ToList()[rnd.Next(0, _context.FelValKerdesek.Count())]);
            
        }while(kivFelValKerdes.Count < db);
        return kivFelValKerdes;
    }

    public ICollection<Kerdes> getVegyesKerdes(int db)
    {
        List<Kerdes> kerdesek = new List<Kerdes>();
        kerdesek.AddRange(_context.FelValKerdesek.ToList());
        kerdesek.AddRange(_context.IgazHamisKerdesek.ToList());
        kerdesek.AddRange(_context.TippelosKerdesek.ToList());
        List<Kerdes> vegyeskerdesek = new List<Kerdes>();

        do
        {
            vegyeskerdesek.Add(kerdesek[rnd.Next(0, kerdesek.Count())]);
        }
        while(vegyeskerdesek.Count < db);
        
        
        
        
        return vegyeskerdesek;
    }
}