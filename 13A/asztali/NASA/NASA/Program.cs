using NASA.Models;

namespace NASA
{
    internal class Program
    {
        static List<Keres> k;
        static void Main(string[] args)
        {
            k = new List<Keres>();
            FajlBeolvas();

            Console.WriteLine($"5. Feladat: Kérések száma: {k.Count()} db");
            Console.WriteLine($"6. Feladat {k.Sum(i => i.ByteMeret)} byte");
            Console.WriteLine($"8. Feladat: {(double)k.Where(i => i.Domain()).Count() / (double)k.Count() * 100:00.00}%");

            Console.WriteLine("Statisztika Szotar:");
            Dictionary<string, int> szt = new Dictionary<string, int>();
            foreach (Keres key in k)
            {
                 if (szt.ContainsKey(key.HttpKod)) { szt[key.HttpKod]++; }
                else { szt[key.HttpKod] = 1; }
            }
            foreach (KeyValuePair<string, int> s in szt) {  Console.WriteLine($"{s.Key}: {s.Value}  "); }

            Console.WriteLine("Statisztika Groupby:");

            var gk = k.GroupBy(x => x.HttpKod);
            foreach (var i in gk) {
                Console.WriteLine($"{i.Key} : {i.Count()}");
            }

        
        }

        private static void FajlBeolvas()
        {
            foreach (string s in File.ReadAllLines("NASAlog.txt").ToList()) k.Add(new Keres(s)); 
        }
    }
}
