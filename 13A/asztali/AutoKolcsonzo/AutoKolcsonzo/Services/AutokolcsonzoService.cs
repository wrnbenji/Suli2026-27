using AutoKolcsonzo.Services;
using AutokolcsonzoLibrary.Services;
using AutoKolcsonzoLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsonzoLibrary.Services
{
    public class AutokolcsonzoService : IAutokolcsonzoService
    {
        AutokolcsonzoDbContext _context;
        
        public AutokolcsonzoService()
        {
            _context = new AutokolcsonzoDbContext();
        }
        public List<Berles> AktivBerlesek()
        {
            return _context.Berlesek.Where(v => v.Visszahozva != null).ToList();
        }

        public List<Auto> Autok()
        {

            return _context.Autok.Include(k => k.Kategoria).Include(g => g.Gyarto).OrderBy(i => i.Rendszam).ToList();
        }

        public List<(string Kategoria, int Darab)> KategoriaStatisztika()
        {
            throw new NotImplementedException();
        }

        public List<Berles> Kesesek(DateOnly datum)
        {
            return _context.Berlesek.Where(k => k.Visszahozva != null && datum > k.Hatarido).ToList();

        }

        public List<Auto> SzabadAutok()
        {
            throw new NotImplementedException();
        }

        public List<Ugyfel> Ugyfelek()
        {

            return _context.Ugyfel.ToList();

        }

        public bool UjBerles(int autoId, int ugyfelId, DateOnly kezdet, int napok)
        {
            throw new NotImplementedException();
        }

        public bool UjUgyfel(string nev, string email)
        {
            if (_context.Ugyfel.Any(e => e.Email == email))
                return false;
            else
            {
                _context.Ugyfel.Add(new Ugyfel { Email = email, Nev = nev,});
                _context.SaveChanges();
                return true;

            }
        }

        public bool Visszahozatal(int berlesId, DateOnly datum)
        {
            throw new NotImplementedException();
        }
    }
}
