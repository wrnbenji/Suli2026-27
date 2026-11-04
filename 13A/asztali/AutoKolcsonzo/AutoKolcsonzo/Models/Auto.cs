using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsonzoLibrary.Models
{

    public class Auto
    {
        public int Id { get; set; }
        public string Rendszam { get; set; } = "";
        public string Modell { get; set; } = "";
        public int GyartoId { get; set; }
        public Gyarto Gyarto { get; set; }
        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
        public int Evjarat { get; set; }
        public int NapiDij { get; set; }

        public List<Berles> Berlesek { get; set; } = new();


    }
}
