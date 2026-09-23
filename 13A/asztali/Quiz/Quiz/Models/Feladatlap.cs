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
        public static List<IKerdes> KivalasztottKerdesek { get; set; } = new List<IKerdes>();
        
        public static void FeladatlapQuiz() {

            int pontszam = 0;
            for (int i = 0; i < Kerdesek.Count; i++)
            {
                
                pontszam+= Kerdesek[i].Jatszas();
            }

            Console.WriteLine($"pontszam: {pontszam}");
        }
    }
}
