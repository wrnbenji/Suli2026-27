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
        static public void FelValKerdesekFeltolt()
        {
            
            FileStream fs = new FileStream("Data/IgazHamisKerdesBank.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream) {
                string line = sr.ReadLine();
                Feladatlap.Kerdesek.Add(new FelValKerdes(line));
                Feladatlap.KivalasztottKerdesek.Add(new FelValKerdes(line));
            }
            sr.Close();
            fs.Close();

            

        }
    }
}
