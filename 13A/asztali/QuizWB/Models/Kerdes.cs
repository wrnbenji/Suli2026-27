using Quiz.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    abstract class Kerdes
    {
        public string KerdesSzovege { get; set; } = "";
        public byte Pontszam { get; set; }
        public string Temakor { get; set; } = "";

        abstract protected void Kiiras();
        abstract protected object Bekeres();
        abstract protected byte Ellenorzes(object v);

        // minden kerdes ugyanugy megy: kiir -> beker -> ellenoriz
        public byte Jatszas()
        {
            Kiiras();
            byte pont = Ellenorzes(Bekeres());

            Console.WriteLine("\nNyomj Entert a folytatáshoz...");
            Console.ReadLine();
            return pont;
        }
    }
}
