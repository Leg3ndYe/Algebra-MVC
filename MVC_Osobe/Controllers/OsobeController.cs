using Microsoft.AspNetCore.Mvc;
using MVC_Osobe.Models;

namespace MVC_Osobe.Controllers
{
    public class OsobeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Popisosoba()
        {
            List<Osobe> ljudi = new List<Osobe>();

            ljudi.Add(new Osobe() { ID = 1, Ime = "Pero", Prezime = "Peric", Godine = 20 });
            ljudi.Add(new Osobe() { ID = 2, Ime = "Lovro", Prezime = "Lovren", Godine = 25 });
            ljudi.Add(new Osobe() { ID = 3, Ime = "Korana", Prezime = "Kropf", Godine = 18 });
            ljudi.Add(new Osobe() { ID = 4, Ime = "Banana", Prezime = "Peely", Godine = 13, JePolaznik = false});
            ljudi.Add(new Osobe() { ID = 5, Ime = "Jack", Prezime = "Sparrow", Godine = 15 });
            ljudi.Add(new Osobe() { ID = 6, Ime = "Koki", Prezime = "Kokica", Godine = 34 , JePolaznik = false});

            return View(ljudi);
        }
    }
}
