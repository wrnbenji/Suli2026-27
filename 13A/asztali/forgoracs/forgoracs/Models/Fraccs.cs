using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace forgoracs.Models
{
    internal class Fraccs
    {
        public char[, ] KodLemez { get; set; } 
        public char[,] Titkositott  { get; set; }
        public string? Titkositando { get; set; }

        public Fraccs(string titkositando )
        {
            KodLemez = new char[8, 8];
            Titkositott = new char[8, 8];
            Titkositando = titkositando;
            FileStream fs = new FileStream("kodlemez.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    string s = sr.ReadLine();
                    for (int sor = 0; sor < 8; sor++) {
                        KodLemez[oszlop, sor] = s[sor];

                       
                            }
                }
                    
                
            }

       

            sr.Close();
            fs.Close();

            Atlakit();
        }
        public string KiirKodlemez(char[,] c)
        {
            string kiiras = "";

            for (int oszlop = 0; oszlop < 8; oszlop++)
            {
                for (int sor = 0; sor < 8; sor++)
                {
                    kiiras += c[oszlop, sor];
                }
                kiiras += "\n";
            }

            return kiiras;
        }

        public char[,] ForgatKodlemez()
        {
            char[,] ujKodlemez = new char[8, 8];
            for (int oszlop = 0;oszlop < 8; oszlop++)
            {
                for (int sor = 0; sor < 8; sor++)
                    ujKodlemez[oszlop, 7 - sor] = KodLemez[oszlop, sor];
            }

            return ujKodlemez;
        }

        public void Titkosit() { 
        int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    for (int sor = 0; sor < 8; sor++)
                    {
                        if (KodLemez[oszlop, sor] == 'A')
                        {
                            Titkositott[oszlop, sor] = Titkositando[index];
                            index++;
                        }
                    }
                }
                KodLemez= ForgatKodlemez();
            }
        }

        public string Atlakit() {
            try {

                string tisztitott = "";
                for (int i =0; i < Titkositando.Length; i++)
                {
                    if (char.IsLetterOrDigit( Titkositando[i]))
                        tisztitott += Titkositando[i];
                }
                if (tisztitott.Length > 64) throw new Exception("Túl hosszú a titkosítandó szöveg!");
                else
                {
                    while(tisztitott.Length!=64) tisztitott+="X";
                }
             return tisztitott;
            
            }
            catch (Exception e){
                return e.Message;
            }
            

        }


    }
}
