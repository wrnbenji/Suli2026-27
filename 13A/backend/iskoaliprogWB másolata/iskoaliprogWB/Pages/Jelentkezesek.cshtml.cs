using iskoaliprogWB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iskoaliprogWB.Pages
{
    public class JelentkezesekModel : PageModel
    {
        
    public JelentkezesContext _context;

        public List<Jelentkezes> Jelentkezesek { get; set; } = new();

        public JelentkezesekModel(JelentkezesContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Jelentkezesek = _context.jelentkezesek.ToList();
        }
    }
}
