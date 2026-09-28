using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tanulok.Models;
using static System.Net.Mime.MediaTypeNames;

namespace tanulok.Pages
{
    public class AdatokModel : PageModel
    {

        TanuloContext _cont;
        
        public List<Tanulo> TanuloKiiras { get; set; }

        public void OnGet()
        {
            foreach(Tanulo t in _cont.Tanulok)
            {
                TanuloKiiras.Add(t);
            }
        }
        public AdatokModel(TanuloContext t)
        {

            _cont = t;
        }
    }
}
