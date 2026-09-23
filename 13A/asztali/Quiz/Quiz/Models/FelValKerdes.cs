using Quiz.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Quiz.Models
{
    internal class FelValKerdes : Kerdes, IKerdes
    {
        static public List<IKerdes> FelValKerdesek = new List<IKerdes>();
        public string Kerdes { get; set; }
        public List<string> ValaszLehetosegek { get; set; }
        public int HelyesValaszIndex { get; set; }
        public byte Pontszam { get; set; }
        public string  Temakor { get; set; }

        public FelValKerdes(string line)
        {
            string[] tomb = line.Split(';');
            Kerdes = tomb[0];
            for (int i = 1; i < 6; i++) {
                ValaszLehetosegek.Add(tomb[i]);
            }
            HelyesValaszIndex = int.Parse(tomb[7]);
            Pontszam = byte.Parse(tomb[8]);
            Temakor = tomb[9];



        }

        public byte Jatszas()
        {
            Kiiras();
            return Ellenorzes(Bekeres());
        }

        protected override object Bekeres()
        {
            string valasz = Console.ReadLine();

            return valasz;
        }

        protected override byte Ellenorzes(object v)
        {
            if ((byte)v == (byte)HelyesValaszIndex)
                return Pontszam;
            else return 0;
        }

        protected override void Kiiras()
        {
            Console.Clear();
            Console.WriteLine("Felelet válaszós kérdés következik: (1-4)\n");
            Console.Write(Kerdes);
            for(int i = 0 ; i<ValaszLehetosegek.Count; i++)
                Console.Write($"{i}: {ValaszLehetosegek[i]}, ");

        }
    }
}
