using Microsoft.AspNetCore.Mvc;
using MVC_Razor_syntax.Models;
using System.Diagnostics;

namespace MVC_Razor_syntax.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Primjer()
        {
            return View();
        }

        public IActionResult Primjer2()
        {
            return View();
        }

        public IActionResult Primjer3()
        {
            return View();
        }

        public IActionResult IfGrananje()
        {
            return View();
        }

        public IActionResult SwitchPrimjer()
        {
            return View();
        }

        public IActionResult ForPetlja()
        {
            return View();
        }

        public IActionResult WhilePetlja()
        {
            return View();
        }

        public IActionResult ForEachPetlja()
        {
            return View();
        }

        public IActionResult Student()
        {
            Student s = new Student()
            {
                ID = 1,
                Ime = "Marko",
                Prezime = "Markovic",
                Dob = 20
            };

            ViewBag.Poruka = "Rusi ga!";

            return View(s);
        }

        public IActionResult Varijable()
        {
            return View();
        }
    }
}