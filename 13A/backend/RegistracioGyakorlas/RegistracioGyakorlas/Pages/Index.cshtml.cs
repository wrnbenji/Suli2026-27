using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistracioGyakorlas.Modles;
using System.Runtime.CompilerServices;

namespace RegistracioGyakorlas.Pages
{
    public class IndexModel : PageModel
    {
        

        [BindProperty]
        public Adat adatocska { get; set; }
        public List<Adat> UjAdat { get; set; } = Adat.adatok;

        public void OnGet()
        {
        }
        public void OnPost() {

            Adat.adatok.Add(adatocska);
            if (ModelState.IsValid)
            {
             
                Console.WriteLine($"Név: {adatocska.Nev} \nEmail: {adatocska.Email}\nSzületési Dátum: {adatocska.SzuletesiDatum}\nDiák: {adatocska.Diak}\nCipõméret: {adatocska.CipoMeret}\nSorszám {adatocska.Sorszam}");
            }
            else
            {
                foreach(var i in ModelState)
                {
                    Console.WriteLine($"Hibás elemek: {ModelState.Keys}");
                    
                    
                }
            }
            

            //adats = Adat.adatok;
        }
    }
}
