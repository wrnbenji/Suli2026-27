
using forgoracs.Models;

namespace forgoracs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szoveg;
            FileStream fs = new FileStream("szoveg.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            szoveg = sr.ReadToEnd();
            sr.Close();
            fs.Close();

            Console.WriteLine(szoveg);

            Fraccs f = new Fraccs(szoveg);

            Console.WriteLine(f.KiirKodlemez(f.KodLemez));

            Console.WriteLine(f.Atlakit());

            Console.WriteLine(f.KiirKodlemez(f.Titkositott));
        }

      
    }
}
