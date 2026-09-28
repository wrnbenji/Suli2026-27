using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tanulok.Models;

namespace tanulok.Pages
{
    public class IndexModel : PageModel
    {
        TanuloContext _cont;
        [BindProperty]
        public Tanulo tanulok1 { get; set; }

        public void OnGet()
        {
            

        }
        public IndexModel(TanuloContext t)
        {

            _cont = t;
        }
        public void OnPost() {
            if (ModelState.IsValid)
            {
                Console.WriteLine(tanulok1.nev);
                _cont.Tanulok.Add(tanulok1);
                _cont.SaveChanges();
            }
            else
            {
                Console.WriteLine("hiba");
            }
            
            

        }
    }
}
