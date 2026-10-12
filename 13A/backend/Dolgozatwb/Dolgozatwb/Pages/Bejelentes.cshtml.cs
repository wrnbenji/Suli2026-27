using Dolgozatwb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Dolgozatwb.Pages
{
    public class BejelentesModel : PageModel
    {
        [BindProperty]
        public Bejelentes UjBejelentes { get; set; }
        BejelentoContext _cont;
        public BejelentesModel (BejelentoContext f)
        {


            _cont = f;
        }
        public void OnPost()
        {


            Console.WriteLine(UjBejelentes.EszkozTipus);
            _cont.bejeletesek.Add(UjBejelentes);
            _cont.SaveChanges();


        }
       
    }
}
