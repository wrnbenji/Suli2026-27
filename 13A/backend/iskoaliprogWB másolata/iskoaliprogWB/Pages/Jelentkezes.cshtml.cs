using iskoaliprogWB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace iskoaliprogWB.Pages
{
    public class JelentkezesModel : PageModel
    {
        [BindProperty]
        public Jelentkezes jelentkezes {  get; set; }

       

        private  JelentkezesContext _context;
            
        public JelentkezesModel(JelentkezesContext context) {

            _context = context;
            
        }
        public void OnPost()
        {

            
            _context.jelentkezesek.Add(jelentkezes);
            _context.SaveChanges();

        }
    }
}
