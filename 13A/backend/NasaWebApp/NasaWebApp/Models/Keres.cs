using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaWebApp.Models
{
    public class Keres
    {
        public string Cim { get; set; }
        public string DatumIdo { get; set; }
        public string GET { get; set; }
        public string HttpKod { get; set; }
        public string Meret { get; set; }
        public int ByteMeret { get { return Meret == "-" ? 0 : int.Parse(Meret); }   
        }

        public bool Domain()
        {
            if (char.IsNumber(Cim[Cim.Length - 1]))
                return false;
            return true;
        } 

        public Keres(string s)
        {
            string[] d = s.Split('*');
            Cim = d[0];
            DatumIdo = d[1];
            GET = d[2];
            HttpKod = d[3].Split(" ")[0];
            Meret = d[3].Split(" ")[1];
        }
    }
}
