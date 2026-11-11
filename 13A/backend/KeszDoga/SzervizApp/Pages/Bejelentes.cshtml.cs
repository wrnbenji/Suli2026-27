using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SzervizApp.Models;

namespace SzervizApp.Pages
{
    public class BejelentesModel : PageModel
    {
        private readonly SzervizContext _context;

        public BejelentesModel(SzervizContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bejelentes UjBejelentes { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Hibás adatnál visszaadjuk az űrlapot a hibaüzenetekkel
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // A dátumot mindig a szerver állítja be, mentéskor
            UjBejelentes.BejelentesDatuma = DateTime.Now;

            _context.Bejelentesek.Add(UjBejelentes);
            _context.SaveChanges();

            return RedirectToPage("/Bejelentesek");
        }
    }
}
