using AutoKolcsonzoLibrary.Models;
using AutoKolcsonzoLibrary.Services;

namespace AutoKolcsonzoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutokolcsonzoService autokolcsonzo = new AutokolcsonzoService();

            foreach(Auto a in autokolcsonzo.Autok())
            {
                Console.WriteLine(a.Gyarto.Nev);
            }
            
        }
    }
}
