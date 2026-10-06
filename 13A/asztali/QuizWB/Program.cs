using Quiz.Models;
using System.Text;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Feltolt.MindentFeltolt();

            bool fut = true;
            while (fut)
            {
                Console.Clear();
                Console.WriteLine("=== KVÍZ JÁTÉK ===");
                Console.WriteLine($"({Feladatlap.Kerdesek.Count} kérdés betöltve)\n");
                Console.WriteLine("1. Új játék");
                Console.WriteLine("2. Kilépés");
                Console.Write("\nVálassz (1-2): ");

                string valasz = Console.ReadLine() ?? "";

                if (valasz == "1") KvizInditasa();
                else if (valasz == "2")
                {
                    fut = false;
                    Console.WriteLine("\nKöszönöm a játékot!");
                }
            }
        }

        private static void KvizInditasa()
        {
            Console.Clear();
            Console.WriteLine("--- KVÍZ BEÁLLÍTÁSA ---\n");

            int db = DarabBekeres();
            Type? tipus = TipusValasztas();
            string? temakor = TemakorValasztas(tipus);

            Feladatlap lap = new Feladatlap(db, tipus, temakor);

            if (lap.KivalasztottKerdesek.Count == 0)
            {
                Console.WriteLine("\nNincs ilyen kérdés. Nyomj Entert a visszatéréshez...");
                Console.ReadLine();
                return;
            }

            Console.Clear();
            Console.WriteLine($"A kvízbe bekerült {lap.KivalasztottKerdesek.Count} db kérdés (max {lap.MaxPont} pont).");
            Console.WriteLine("Nyomj Entert az indításhoz!");
            Console.ReadLine();

            int pontszam = lap.FeladatlapQuiz();

            Console.Clear();
            Console.WriteLine("=== VÉGE ===");
            Console.WriteLine($"Elért pontszám: {pontszam} / {lap.MaxPont} pont ({(double)pontszam / lap.MaxPont * 100:0}%)");
            Console.WriteLine("\nNyomj Entert a visszatéréshez...");
            Console.ReadLine();
        }

        private static int DarabBekeres()
        {
            Console.Write("Hány kérdést szeretnél? (alap: 5): ");
            if (int.TryParse(Console.ReadLine(), out int db) && db > 0) return db;
            return 5;
        }

        // null = vegyes
        private static Type? TipusValasztas()
        {
            Console.WriteLine("\nMilyen kérdések legyenek?");
            Console.WriteLine(" 1 - Feleletválasztós\n 2 - Igaz-hamis\n 3 - Tippelős\n 4 - Vegyes");

            while (true)
            {
                Console.Write("Válassz típust (1-4): ");
                string valasz = Console.ReadLine() ?? "";

                if (valasz == "1") return typeof(FelValKerdes);
                else if (valasz == "2") return typeof(IgazHamisKerdes);
                else if (valasz == "3") return typeof(TippelosKerdes);
                else if (valasz == "4") return null;

                Console.WriteLine("Hibás választás!");
            }
        }

        // szammal lehet valasztani, igy nem kell ekezetet gepelni, null = mindegy
        private static string? TemakorValasztas(Type? tipus)
        {
            List<string> temak = Feladatlap.Temakorok(tipus);

            Console.WriteLine("\nTémakörök:");
            for (int i = 0; i < temak.Count; i++)
                Console.WriteLine($" {i + 1,2} - {temak[i]}");

            while (true)
            {
                Console.Write("Válassz témakört (üresen hagyva mindegy): ");
                string valasz = (Console.ReadLine() ?? "").Trim();

                if (valasz == "") return null;
                if (int.TryParse(valasz, out int index) && index >= 1 && index <= temak.Count) return temak[index - 1];

                Console.WriteLine("Hibás választás!");
            }
        }
    }
}
