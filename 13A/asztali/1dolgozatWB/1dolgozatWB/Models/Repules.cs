using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dolgozatWB.Models
{
    //dron;indulas;erkezes;honnan;hova;tomeg;akku_indulas;akku_erkezes;homerseklet;statusz 
    internal class Repules
    {
        public string dron { get; set; }
        public string indulas { get; set; }
        public string erkezes { get; set; }
        public string honnan { get; set; }
        public string hova { get; set; }
        public double tomeg { get; set; }
        public int akku_indulas { get; set; }
        public int akku_erkezes { get; set; }
        public int homerseklet { get; set; }
        public string statusz { get; set; }
        public Repules(string sor)
        {
            string[] tomb = sor.Split(";");
            dron = tomb[0];
            indulas = tomb[1];
            erkezes = tomb[2];
            honnan = tomb[3];
            hova = tomb[4];
            tomeg = double.Parse(tomb[5]);
            akku_indulas = int.Parse(tomb[6]);
            akku_erkezes = int.Parse(tomb[7]);
            homerseklet = int.Parse(tomb[8]);
            statusz = tomb[9];
            
        }
        public int RepulesPerc()
        {
            int indulasOra, indulasPerc;
            indulasOra = int.Parse(indulas.Split(":")[0]);
            indulasPerc = int.Parse(indulas.Split(':')[1]);
            int erkezesOra, erkezesPerc;
            erkezesOra = int.Parse(erkezes.Split(":")[0]);
            erkezesPerc = int.Parse(erkezes.Split(":")[0]);

            int iPerc = indulasOra*60+indulasPerc;
            int ePerc = erkezesOra*60+erkezesPerc;
            return ePerc-iPerc;
        }
       public int akkuFogyasztas()
        {
            return akku_indulas-akku_erkezes;
        }
    }
}
