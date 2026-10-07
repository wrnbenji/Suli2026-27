using Quiz.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    //kerdes;valasz1;valasz2;valasz3;valasz4;helyesIndex(0-3);pont;temakor
    internal class FelValKerdes : Kerdes, IKerdes
    {
        static public List<FelValKerdes> FelValKerdesek = new List<FelValKerdes>();
        public List<string> ValaszLehetosegek { get; set; } = new List<string>();
        public int HelyesValaszIndex { get; set; }

        public FelValKerdes(string line)
        {
            string[] tomb = line.Split(';');
            KerdesSzovege = tomb[0];
            for (int i = 1; i < 5; i++)
                ValaszLehetosegek.Add(tomb[i]);
            HelyesValaszIndex = int.Parse(tomb[5]);
            Pontszam = byte.Parse(tomb[6]);
            Temakor = tomb[7];
        }

        protected override void Kiiras()
        {
            Console.Clear();
            Console.WriteLine($"Feleletválasztós kérdés következik! ({Temakor}, {Pontszam} pont)\n");
            Console.WriteLine(KerdesSzovege);
            for (int i = 0; i < ValaszLehetosegek.Count; i++)
                Console.WriteLine($"  {i + 1}: {ValaszLehetosegek[i]}");
            Console.Write("\nVálasz (1-4): ");
        }

        protected override object Bekeres()
        {
            int valasz;
            while (!int.TryParse(Console.ReadLine(), out valasz) || valasz < 1 || valasz > 4)
                Console.Write("Hibás formátum, 1-4 közötti számot adj meg: ");

            return valasz - 1; 
        }

        protected override byte Ellenorzes(object v)
        {
            if ((int)v == HelyesValaszIndex)
            {
                Console.WriteLine($"Helyes! +{Pontszam} pont");
                return Pontszam;
            }
            Console.WriteLine($"Rossz válasz! A helyes: {HelyesValaszIndex + 1}: {ValaszLehetosegek[HelyesValaszIndex]}");
            return 0;
        }
    }
}
