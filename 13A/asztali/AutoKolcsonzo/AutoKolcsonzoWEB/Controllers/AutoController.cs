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
            return View();
        }
        public IActionResult OsszesAuto()
        {
            List<Auto> autoList = _serv.Autok();
            return View(autoList);
        }
        public IActionResult Szabad()
        {
            List<Auto> autoList = _serv.SzabadAutok();
            return View(autoList);
        }
        [HttpGet]
        public IActionResult UjGyarto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UjGyarto(Gyarto uj)
        {
            if (ModelState.IsValid)
            {
                _serv.UjGyarto(uj.Nev);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult UjKategoria()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UjKategoria(Gyarto uj)
        {
            if (ModelState.IsValid)
            {
                _serv.UjKategoria(uj.Nev);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
