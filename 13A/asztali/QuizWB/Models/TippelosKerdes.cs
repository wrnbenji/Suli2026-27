using Quiz.InterFace;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    //kerdes;helyes szam;pont;megengedett elteres %;temakor
    internal class TippelosKerdes : Kerdes, IKerdes
    {
        static public List<TippelosKerdes> TippelosKerdesek = new List<TippelosKerdes>();
        public double HelyesValasz { get; set; }
        public byte SzazalekElteres { get; set; }

        public TippelosKerdes(string line)
        {
            string[] tomb = line.Split(';');
            KerdesSzovege = tomb[0];
            HelyesValasz = SzamParse(tomb[1]);
            Pontszam = byte.Parse(tomb[2]);
            SzazalekElteres = byte.Parse(tomb[3]);
            Temakor = tomb[4];
        }

        // a fajlban vesszo van (9,81), de pontot is elfogadunk
        static double SzamParse(string s)
        {
            return double.Parse(s.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
        }

        protected override void Kiiras()
        {
            Console.Clear();
            Console.WriteLine($"Tippelős kérdés következik! ({Temakor}, {Pontszam} pont)\n");
            Console.WriteLine(KerdesSzovege);
            if (SzazalekElteres > 0) Console.WriteLine($"(Megengedett eltérés: {SzazalekElteres}%)");
            else Console.WriteLine("(Pontos válasz kell)");
            Console.Write("\nTipp: ");
        }

        protected override object Bekeres()
        {
            while (true)
            {
                try
                {
                    return SzamParse(Console.ReadLine() ?? "");
                }
                catch (Exception)
                {
                    Console.Write("Hibás formátum, számot adj meg: ");
                }
            }
        }

        protected override byte Ellenorzes(object v)
        {
            double tipp = (double)v;
            double maxElteres = Math.Abs(HelyesValasz) * SzazalekElteres / 100;

            if (Math.Abs(tipp - HelyesValasz) <= maxElteres)
            {
                Console.WriteLine($"Helyes! A pontos válasz: {HelyesValasz} | +{Pontszam} pont");
                return Pontszam;
            }
            Console.WriteLine($"Nem talált! A helyes válasz: {HelyesValasz}");
            return 0;
        }
    }
}
