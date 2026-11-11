using Microsoft.AspNetCore.Mvc.RazorPages;
using SzervizApp.Models;

namespace SzervizApp.Pages
{
    public class BejelentesekModel : PageModel
    {
        private readonly SzervizContext _context;

        public BejelentesekModel(SzervizContext context)
        {
            _context = context;
        }

        public List<Bejelentes> Bejelentesek { get; set; } = new();

        public void OnGet()
        {
            Bejelentesek = _context.Bejelentesek
                .OrderByDescending(b => b.BejelentesDatuma)
                .ToList();
        }
    }
}
