using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NasaWebApp.Pages
{
    public class UrlapModel : PageModel
    {
        public string Tartalom { get; set; }
        public string Kapott { get; set; }
        public void OnGet(string x)
        {
             Kapott = x;
        }
        public void OnPost()
        {
            string name = Request.Form["nev"];
            int szam = int.Parse(Request.Form["szam"]);
            Tartalom = $" Név: {name}, SZám: {szam}";
        }
    }
}
