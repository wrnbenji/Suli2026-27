
using _1dolgozatWB.Models;
using System.Runtime.InteropServices;

namespace _1dolgozatWB
{
    internal class Program
    {
        static List<Repules> repulesek = new();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Console.WriteLine($"3. feladat\n repülések Száma: {repulesek.Count}");
            SikeresSzazelek();
            LegnagyobbFogyas();
            Tomeghatar();
            HuszonAlatti();
            DronStatisztika();
            LegtobbSikeres();
            Atlagosfogyas();

            EnergiaRiado();

        }

        private static void EnergiaRiado()
        {
            FileStream fs = new FileStream("energiariasztas.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs);

            List<Repules> adatok = repulesek.Where(i => i.akku_erkezes <20 || i.akkuFogyasztas()>22).ToList();

            foreach (Repules repule in adatok)
            {
                streamWriter.WriteLine($"{repule.dron};{repule.indulas};{repule.erkezes};{repule.akkuFogyasztas};{repule.akku_erkezes}");
            }

        }

        private static void Atlagosfogyas()
        {
            List<Repules> felett = repulesek.Where(i => i.homerseklet >= 25).ToList();
            double felettatlag = felett.Average(i => i.homerseklet);
            List<Repules> alatt = repulesek.Where(i => i.homerseklet < 25).ToList();
            double alattatlag = alatt.Average(i => i.homerseklet);

            Console.WriteLine($"10 feladat: \n homerseklet legalabb 25{felettatlag}\n alatta{alattatlag}");
        }

        private static void LegtobbSikeres()
        {
            List<Repules> sikeres = repulesek.Where(i => i.statusz == "Sikeres").ToList();

           Dictionary<string, int> szt = new Dictionary<string, int>();
            foreach (Repules s in sikeres) { 
            if (szt.ContainsKey(s.hova))
                    szt[s.hova]++;
            else szt[s.hova] = 1;
            
            
            }
            Console.WriteLine($"9. feladat\nlegsikereseb celpont: \nhely: {szt.Keys.Max()}\ndb: {szt.Values.Max()}");

            

        }

        private static void DronStatisztika()
        {
            Console.WriteLine("Adjon meg egy dronazonosítót: ");
            string dron = Console.ReadLine();

            int repulesdb = repulesek.Where(i => i.dron == dron).Count();
            List<Repules> dronok = repulesek.Where(i => i.dron == dron).ToList();

            int percek = dronok.Sum(i => i.RepulesPerc());
            double ossztomeg = dronok.Sum(i => i.tomeg);
            Console.WriteLine($"8. feladat" +
                $"\nRepülések száma : {repulesdb}" +
                $"\n Összes repült perc : {percek}" +
                $"\n össztömeg {ossztomeg}");

        }



        private static void HuszonAlatti()
        {
            int db = repulesek.Where(i => i.akku_erkezes < 25 && i.statusz =="Sikeres" ).Count();
            Console.WriteLine($"25% töltöttségel érkező sikeres repülések: {db}");
        }

        private static void Tomeghatar()
        {
            double tomeg;
            try {
                Console.WriteLine($"6.feladat \nAdja meg a tömeghatárt kg-ban: ");
                tomeg = Double.Parse( Console.ReadLine() );
            }
            catch(Exception e) {
                Console.WriteLine("Hibas formátum az alap 2,5 kg lesz használva...");
                tomeg = 2.5;

            }
            int db = repulesek.Where(i => i.tomeg > tomeg).Count();
            Console.WriteLine($"A határnál nehezebb csomagot szállító repülések száma: {db} db");
        }

        private static void LegnagyobbFogyas()
        {
            int legnFogyas = repulesek.Max(i => i.akkuFogyasztas());
            Repules keresett = repulesek.FirstOrDefault(i => i.akkuFogyasztas() == legnFogyas);

            Console.WriteLine($"5. feladat: " +
                $"\n Drón {keresett.dron}" +
                $"\nÚtvonal: {keresett.honnan} -> {keresett.erkezes}" +
                $"\nFogyás : {keresett.akkuFogyasztas()} százalékpont");
        }

        static void SikeresSzazelek()
        {
            int sikeresDb = repulesek.Where(i => i.statusz =="Sikeres").Count();
            Console.WriteLine($"4. feladat" +
                $"\n Sikeres küldetések aránya: {(double)sikeresDb/ (double)repulesek.Count * 100}");

        }
        private static void Fajlbeolvasas()
        {
            try
            {
                FileStream fs = new FileStream("dronnaplo.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    repulesek.Add(new Repules(line));

                }
                sr.Close();
                fs.Close();
            }
            catch (FileNotFoundException) {
                Console.WriteLine("fájl nem találhato");
            }
        }
    }
}
