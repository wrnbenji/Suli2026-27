using AutokolcsonzoLibrary.Services;
using AutoKolcsonzoLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoKolcsonzoWEB.Controllers
{
    public class AutoController : Controller
    {
        private readonly IAutokolcsonzoService _serv;
        public AutoController(IAutokolcsonzoService service) {

            _serv = service;
        }
        public IActionResult Index()
        {
            List<Auto> autoList = _serv.Autok();
            return View(autoList);
        }
        public IActionResult Szabad()
        {
            List<Auto> autoList = _serv.SzabadAutok();
            return View(autoList);
        }
    }
}
