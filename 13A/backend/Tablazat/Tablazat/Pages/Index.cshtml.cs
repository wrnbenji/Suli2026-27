using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tablazat.Models;

namespace Tablazat.Pages
{
    public class IndexModel : PageModel
    {
        public List<Felhasznalo> felhasznalok { get; set; }=Felhasznalo.felhasznalo;
        public void OnPost()
        { 
            felhasznalok.Add(new Felhasznalo(Request.Form["nev"], Request.Form["email"], Request.Form["jelszo"]));

        }
    }
}
