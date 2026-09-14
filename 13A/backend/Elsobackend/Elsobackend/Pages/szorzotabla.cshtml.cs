using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Elsobackend.Pages
{
    public class szorzotablaModel : PageModel
    {
        public int melyikSzam { get; set; }
        public int meddigSzam { get; set; }
        public void OnGet()
        {
            meddigSzam = 30;
            melyikSzam = 4;
        }
    }
}
