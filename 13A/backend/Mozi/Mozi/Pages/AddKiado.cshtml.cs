using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mozi.Models;
using System.Diagnostics.Eventing.Reader;

namespace Mozi.Pages
{
    public class AddKiadoModel : PageModel
    {
        
        [BindProperty]
        public Kiado UjKiado { get; set; }
        FilmContext _cont;
        public AddKiadoModel(FilmContext f) {
            
        
            _cont = f;
        }
        public void OnPost()
        {
           
            
                Console.WriteLine(UjKiado.KiadoNev);
                _cont.kidadok.Add(UjKiado);
            _cont.SaveChanges();
           
            
        }
    }
}
