using KonyvtarLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarLibrary.Services
{
    public class KonyvtarService : IKonyvtarService
    {
        static KonyvtarDbContext _cont = new KonyvtarDbContext();
        public List<Kolcsonzes> AktivKolcsonzesek()
        {
            throw new NotImplementedException();
        }

        public List<Konyv> ElerhetoKonyvek()
        {
           List<int> elerhetokkonyvekid = _cont.Kolcsonzesek.Where(i=> i.Visszahozva == null).Select(i => i.KonyvId).ToList();
            List<Konyv> elerheoK = new List<Konyv>();
            foreach (Konyv i in _cont.Konyvek) { 
            if(elerhetokkonyvekid.Contains(i.Id))
                    elerheoK.Add(i);
            
            }
            return elerheoK;
        }

        public List<Kolcsonzes> Kesesek(DateOnly datum)
        {
           List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();
            kolcsonzesek = _cont.Kolcsonzesek.Where(i => i.Visszahozva == null && i.Hatarido < datum).ToList() ;

            return kolcsonzesek;
        }

        public List<Konyv> Konyvek()
        {
            List<Konyv> konyvek = new List<Konyv>();
            
            konyvek = _cont.Konyvek.ToList();
            return konyvek;
        }

        public List<Olvaso> Olvasok()
        {
            List<Olvaso> olvasok = new List<Olvaso>();

            olvasok = _cont.Olvasok.ToList();       
              return olvasok;

        }

        public Dictionary<string, int> OlvasoStatisztika()
        {
            Dictionary<string, int> szt = new Dictionary<string, int>();
            foreach (Olvaso o in _cont.Olvasok) { 
            if (szt.ContainsKey(o.Nev))
                    szt[o.Nev] = 0;
            }
            
            return szt;

        }

        public bool UjKolcsonzes(int konyvId, int olvasoId, DateOnly kezdet)
        {
            
            throw new NotImplementedException();


        }

        public bool UjOlvaso(string nev, string email)
        {

            if (_cont.Olvasok.Where(i => i.Email == email).Count() == 0 ) { 
                _cont.Olvasok.Add(new Olvaso{ Email = email, Nev = nev, Aktiv = true }); return true; }
            
            else return false;
        }

        public bool Visszahozatal(int kolcsonzesId, DateOnly datum)
        {
            throw new NotImplementedException();
        }
    }
}
