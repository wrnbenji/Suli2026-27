using Quiz.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    internal class Feladatlap
    {
        public static List<IKerdes> Kerdesek { get; set; } = new List<IKerdes>();
        public List<IKerdes> KivalasztottKerdesek { get; set; } = new List<IKerdes>();
        public int MaxPont { get { return KivalasztottKerdesek.Sum(i => i.Pontszam); } }

        static Random rnd = new Random();

        public Feladatlap(int db) : this(db, null, null) { }                    // vegyes, barmilyen tema
        public Feladatlap(int db, Type tipus) : this(db, tipus, null) { }       // csak tipus
        public Feladatlap(int db, string temakor) : this(db, null, temakor) { } // csak tema

        // null = mindegy
        public Feladatlap(int db, Type? tipus, string? temakor)
        {
            List<IKerdes> szurt = Kerdesek
                .Where(i => (tipus == null || i.GetType() == tipus) && (temakor == null || i.Temakor == temakor))
                .ToList();

            if (db > szurt.Count) db = szurt.Count;

            // megkeveri es kiveszi az elso db-t -> nincs ismetles
            KivalasztottKerdesek = szurt.OrderBy(i => rnd.Next()).Take(db).ToList();
        }

        public int FeladatlapQuiz()
        {
            int pontszam = 0;
            for (int i = 0; i < KivalasztottKerdesek.Count; i++)
            {
                pontszam += KivalasztottKerdesek[i].Jatszas();
            }
            return pontszam;
        }

        // a valasztott tipushoz tartozo temakorok abc sorrendben
        public static List<string> Temakorok(Type? tipus)
        {
            return Kerdesek
                .Where(i => tipus == null || i.GetType() == tipus)
                .Select(i => i.Temakor)
                .Distinct()
                .OrderBy(i => i)
                .ToList();
        }
    }
}
