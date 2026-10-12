using Dolgozatwb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dolgozatwb.Pages
{
    public class BejelentesekModel : PageModel
    {
        BejelentoContext _cont;
        public BejelentesekModel(BejelentoContext f)
        {


            _cont = f;
        }
        public List<Bejelentes> UjBejelentesek { get; set; } 
        
        
        public void OnGet()
        {
            foreach(Bejelentes i in _cont.bejeletesek)
        {
                UjBejelentesek.Add(i);
               
            }

        }
    }
}
