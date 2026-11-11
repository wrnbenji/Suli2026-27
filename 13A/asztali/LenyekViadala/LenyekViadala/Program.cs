using LenyekViadala.Models;
using System.Diagnostics;

namespace LenyekViadala
{
    internal class Program
    {
        public delegate void Kiiras(string nev, int nap);

        static List<Leny> Lenyek = new List<Leny>() { new Homokjaro(), new Lepegeto(), new Szivacs() };

        static void Main(string[] args)
        {
            Jatek(); 
        }

        static void Jatek()
        {
            List<string> list = new List<string>() { "esos", "napos", "felhos" };
            Random random = new Random();
            string idojaras;
            int nap = 0;
            do
            {
                idojaras = list[random.Next(list.Count)];
               foreach(Leny i in Lenyek)
                {
                    
                    i.Idojarasvaltozas(idojaras);
                    Console.WriteLine($"{i.Name}- Víz : {i.Viz} Tavolság: {i.Tavolsag}\n");
                    nap++;

                }


            } while (Lenyek.Any(l => l.Eletben));
            int helyzes = 1;
            foreach(Leny k in Lenyek.OrderByDescending(t => t.Tavolsag))
            {
                Console.WriteLine($"{helyzes}. {k.Name} távolság: {k.Tavolsag} {k.Napokszama} ");
                helyzes++;
            }

        }
    }
}
