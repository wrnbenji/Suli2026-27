using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mozi.Models;

namespace Mozi.Pages
{
    public class AddMufajModel : PageModel
    {
        [BindProperty]
        public Mufaj UjMufaj { get; set; }
        FilmContext _cont;
        public AddMufajModel(FilmContext f)
        {


            _cont = f;
        }
        public void OnPost()
        {


            Console.WriteLine(Mufaj.MufajNev);
            _cont.kidadok.Add(Mufaj);
            _cont.SaveChanges();


        }
        public void OnGet()
        {
        }
    }
}
