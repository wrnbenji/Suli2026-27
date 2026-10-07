using Kviz;
using Kviz.Services;

namespace KvizKonzol;

class Program
{
    static void Main(string[] args)
    {
        Feladatlap f = new Feladatlap();
        KvizContext k = new KvizContext();
        Console.WriteLine(k.FelValKerdesek.Count());
        Console.WriteLine(k.TippelosKerdesek.Count());
        Console.WriteLine(k.IgazHamisKerdesek.Count());
        
        
    }
}