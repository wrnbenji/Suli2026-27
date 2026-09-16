using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tablazat.Models;

namespace Tablazat.Pages
{
    public class IndexModel : PageModel
    {
        public List<Felhasznalo> felhasznalok { get; set; } = Felhasznalo.felhasznalo;
        public List<Felhasznalo> felhasznalokszures { get; set; }
        public void OnPost()
        { 
            felhasznalok.Add(new Felhasznalo(Request.Form["nev"], Request.Form["email"], Request.Form["jelszo"]));

        }

        public void OnGet(string x)
        {
            string nev = x;
            foreach (Felhasznalo felhasznalo in felhasznalok) {
                if (felhasznalo.nev == nev)
                    felhasznalokszures.Add(felhasznalo);

            }

        }
    }
}
