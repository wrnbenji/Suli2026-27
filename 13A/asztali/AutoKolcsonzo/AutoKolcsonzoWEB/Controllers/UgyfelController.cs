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
        public IActionResult Index()
        {
            List<Ugyfel> list = _szerviz.Ugyfelek();
            return View(list);
        }
    }
}
