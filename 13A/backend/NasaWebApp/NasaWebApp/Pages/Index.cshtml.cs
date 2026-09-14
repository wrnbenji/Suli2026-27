using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NasaWebApp.Models;

namespace NasaWebApp.Pages
{
    public class IndexModel : PageModel
    {
       public  List<Keres> Keresek { get; set; } = new List<Keres>();
        public void OnGet()
        {
            
            FajlBeolvas();
        }
        private void FajlBeolvas()
        {
            foreach (string s in System.IO.File.ReadAllLines("NASAlog.txt").ToList()) Keresek.Add(new Keres(s));
        }
    }
}
