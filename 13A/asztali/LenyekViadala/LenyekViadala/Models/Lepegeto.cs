using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenyekViadala.Models
{
    internal class Lepegeto : Leny
    {

        public Lepegeto() {

            Name = "Lépegető";
            
            FelhosViz = -1;
            FelhosLepes = 2;

            NaposLepes = 1;
            NaposViz = -2;

            EsosViz = 3;
            EsosLepes = 1;

            MaxViz = 12;
            Tavolsag = 0;
            Viz = MaxViz;
            Napokszama = 0;


        }

    }
}
