using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LenyekViadala.Models
{
    public abstract class Leny
    {
        public string Name { get; set; }
        public int Viz { get; set; }
        public int MaxViz { get; set; }
        public int Tavolsag { get; set; }

        public int NaposViz { get; set; }
        public int NaposLepes { get; set; }

        public int EsosViz { get; set; }
        public int EsosLepes { get; set; }

        public int FelhosViz { get; set; }
        public int FelhosLepes { get; set; }

        public int Napokszama { get; set; }

        public bool Eletben { get; set; } = true;

        public void Idojarasvaltozas(string idojaras)
        {
            Elemeg();
            
            if (Eletben)
            {
                Napokszama++;
                if (idojaras == "napos")
                {
                    if (MaxViz < Viz + NaposViz)
                        Viz = MaxViz;
                    else Viz += NaposViz;

                    Tavolsag += NaposLepes;





                }
                if (idojaras == "felhos")
                {
                    if (MaxViz < Viz + FelhosViz)
                        Viz = MaxViz;
                    else Viz += FelhosViz;

                    Tavolsag += FelhosLepes;
                }
                if (idojaras == "esos")
                {
                    if (MaxViz < Viz + EsosViz)
                        Viz = MaxViz;
                    else Viz += EsosViz;

                    Tavolsag += EsosLepes;


                }
            }

        }
        public void Elemeg() {
        
        if (Viz == 0)
            {
                Eletben = false;
            }
        } 







    }
}
