using Quiz.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    //allitas;helyes(1=igaz, 0=hamis);pont;temakor
    internal class IgazHamisKerdes : Kerdes, IKerdes
    {
        static public List<IgazHamisKerdes> IgazHamisKerdesek = new List<IgazHamisKerdes>();
        public bool HelyesValasz { get; set; }

        public IgazHamisKerdes(string line)
        {
            string[] tomb = line.Split(';');
            KerdesSzovege = tomb[0];
            HelyesValasz = tomb[1] == "1";
            Pontszam = byte.Parse(tomb[2]);
            Temakor = tomb[3];
        }

        protected override void Kiiras()
        {
            Console.Clear();
            Console.WriteLine($"Igaz-hamis kérdés következik! ({Temakor}, {Pontszam} pont)\n");
            Console.WriteLine(KerdesSzovege);
            Console.Write("\nIgaz vagy hamis? (i / h): ");
        }

        protected override object Bekeres()
        {
            while (true)
            {
                string valasz = (Console.ReadLine() ? "").Trim().ToLower();

                if (valasz == "i" || valasz == "igaz" || valasz == "1") return true;
                else if (valasz == "h" || valasz == "hamis" || valasz == "0") return false;

                Console.Write("Hibás formátum, i vagy h: ");
            }
        }

        protected override byte Ellenorzes(object v)
        {
            if ((bool)v == HelyesValasz)
            {
                Console.WriteLine($"Helyes! +{Pontszam} pont");
                return Pontszam;
            }
            Console.WriteLine($"Rossz válasz! Az állítás {(HelyesValasz ? "igaz" : "hamis")}.");
            return 0;
        }
    }
}
