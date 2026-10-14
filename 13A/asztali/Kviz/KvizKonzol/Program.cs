using Kviz;
using Kviz.Interface;
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


        List<Kerdes> igazHamisKerdesek = f.getIgazHamisKerdes(1).ToList();
        int pont = 0;
        foreach (Kerdes kerdes in igazHamisKerdesek)
        {
            Console.WriteLine(kerdes.KerdesSzoveg);
            string valasz = Console.ReadLine();
            
            pont += kerdes.Ellenorzes(valasz);
            
        }

        Console.WriteLine($"pontszámod : {pont}");
        
        List<Kerdes> vegyeKerdesek = f.getVegyesKerdes(10).ToList();

        foreach (Kerdes item in  vegyeKerdesek)
        {
            if (item is FelValKerdes)
            {
                FelValKerdes kerdesFV =  item as FelValKerdes;
                
                Console.WriteLine($"Feleletválasztós kérdés következik! {kerdesFV.Pontszam} pont)\n");
                Console.WriteLine(kerdesFV.KerdesSzoveg);
                Console.WriteLine(kerdesFV.Valasz1);
                Console.WriteLine(kerdesFV.Valasz2);
                Console.WriteLine(kerdesFV.Valasz3);
                Console.WriteLine(kerdesFV.Valasz4);
                    
                Console.Write("\nVálasz (1-4): ");
                pont += kerdesFV.Ellenorzes(Console.ReadLine());
            }
            
            if (item is IgazHamisKerdes)
            {
                IgazHamisKerdes kerdesIH = item as IgazHamisKerdes;
                
                Console.WriteLine("Igaz/Hamis Kérdés: ");
                Console.WriteLine(kerdesIH.KerdesSzoveg);
                pont += item.Ellenorzes(Console.ReadLine());
            }
            
            if (item is TippelosKerdes)
            {
                TippelosKerdes kerdesT = item as TippelosKerdes;
                Console.WriteLine($"Tippelős kérdés következik! ({kerdesT.Temakor}, {kerdesT.Pontszam} pont)\n");
                Console.WriteLine(kerdesT.KerdesSzoveg);
                if (kerdesT.SzazalekElteres > 0) Console.WriteLine($"(Megengedett eltérés: {kerdesT.SzazalekElteres}%)");
                else Console.WriteLine("(Pontos válasz kell)");
                Console.Write("\nTipp: ");
                pont += item.Ellenorzes(Console.ReadLine());
            }
            
        }
        
    }
}