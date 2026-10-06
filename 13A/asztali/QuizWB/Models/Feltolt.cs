using Quiz.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Models
{
    static class Feltolt
    {
        static public void MindentFeltolt()
        {
            FelValKerdesekFeltolt();
            IgazHamisKerdesekFeltolt();
            TippelosKerdesekFeltolt();
        }

        static public void FelValKerdesekFeltolt()
        {
            foreach (string line in FajlBeolvas("Data/FeleletValasztosKerdesBank.txt"))
            {
                FelValKerdes k = new FelValKerdes(line);
                FelValKerdes.FelValKerdesek.Add(k);
                Feladatlap.Kerdesek.Add(k);
            }
        }

        static public void IgazHamisKerdesekFeltolt()
        {
            foreach (string line in FajlBeolvas("Data/IgazHamisKerdesBank.txt"))
            {
                IgazHamisKerdes k = new IgazHamisKerdes(line);
                IgazHamisKerdes.IgazHamisKerdesek.Add(k);
                Feladatlap.Kerdesek.Add(k);
            }
        }

        static public void TippelosKerdesekFeltolt()
        {
            foreach (string line in FajlBeolvas("Data/TippelosKerdesBank.txt"))
            {
                TippelosKerdes k = new TippelosKerdes(line);
                TippelosKerdes.TippelosKerdesek.Add(k);
                Feladatlap.Kerdesek.Add(k);
            }
        }

        private static List<string> FajlBeolvas(string utvonal)
        {
            List<string> sorok = new List<string>();
            try
            {
                FileStream fs = new FileStream(utvonal, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    if (line.Trim() != "") sorok.Add(line.Trim());
                }
                sr.Close();
                fs.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"fájl nem található: {utvonal}");
            }
            return sorok;
        }
    }
}
