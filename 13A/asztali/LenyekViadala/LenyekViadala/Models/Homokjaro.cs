using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenyekViadala.Models
{
    public class Homokjaro : Leny
    {
        public Homokjaro()
        {
            Name = "HomokJáró";
            NaposViz = -1;
            FelhosViz = 0;
            
            NaposLepes = 3;
            FelhosLepes = 1;

            EsosViz = 3;
            EsosLepes = 0;
            
            MaxViz = 8;
            Tavolsag = 0;
            Viz = MaxViz;
            Napokszama = 0;

        }
      
    }
}
