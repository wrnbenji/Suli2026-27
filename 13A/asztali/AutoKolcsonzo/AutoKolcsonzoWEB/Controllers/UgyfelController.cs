using AspNetCoreGeneratedDocument;
using AutokolcsonzoLibrary.Services;
using AutoKolcsonzoLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AutoKolcsonzoWEB.Controllers
{
    public class UgyfelController : Controller
    {
        private IAutokolcsonzoService _szerviz;

        public UgyfelController(IAutokolcsonzoService szerviz)
        {
            _szerviz = szerviz;
        }
        public IActionResult OsszesUgyfel()
        {
            List<Ugyfel> list = _szerviz.Ugyfelek();
            return View(list);
        }
        [HttpGet]
        public IActionResult UjUgyfel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UjUgyfel(Ugyfel uj)
        {
            if (ModelState.IsValid)
            {
                _szerviz.UjUgyfel(uj.Nev, uj.Email);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
