using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenyekViadala.Models
{
    internal class Szivacs : Leny
    {
        public Szivacs() {

            Name = "Szivacs";

            FelhosViz = -1;
            FelhosLepes = 1;

            NaposLepes = 0;
            NaposViz = -4;

            EsosViz = 6;
            EsosLepes = 3;

            MaxViz = 20;
            Tavolsag = 0;
            Viz = MaxViz;
            Napokszama = 0;


        }

    }
}
