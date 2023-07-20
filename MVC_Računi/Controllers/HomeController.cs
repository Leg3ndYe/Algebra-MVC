using Microsoft.AspNetCore.Mvc;
using MVC_Računi.Models;
using MVC_Računi.Repository;
using System.Diagnostics;

namespace MVC_Računi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        RepositoryRacuna _repo;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _repo = new RepositoryRacuna();
        }

        public IActionResult Index()
        {
            List<Racun> racuni = _repo.DohvatiSveRacune();
            return View(racuni);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DetaljiRacuna(int id)
        {
            Racun racun = _repo.DohvatiRacunPoBroju(id);

            if(racun != null)
            {
                return View(racun);
            }
            else
            {
                ViewBag.Greska = "Nema racuna s tim brojem";
                List<Racun> racuni = _repo.DohvatiSveRacune();
                return View("Index", racuni);
            }
        }
        [HttpGet]
        public IActionResult DodajNovuStavkuRacuna(int id)
        {
            Racun r = _repo.DohvatiRacunPoBroju(id);
            if(r == null)
            {
                ViewBag.Greska = "Nemoguce dodati stavku racuna na nepostojeci racun";
                List<Racun> racuni = _repo.DohvatiSveRacune();
                return View("Index", racuni);
            }
                ViewBag.BrojRacuna = id;
                StavkaRacuna stavka = new StavkaRacuna();
                return View(stavka);
        }
        [HttpPost]
        public IActionResult DodajNovuStavkuRacuna(StavkaRacuna stavka)
        {
            int brojRacuna = int.Parse(Request.Form["BrojRacuna"]);
            Racun r = _repo.DohvatiRacunPoBroju(brojRacuna);
            if(r == null)
            {
                ViewBag.Greska = "Nemoguce dodati stavku racuna na nepostojeci racun!";
                List<Racun> racuni = _repo.DohvatiSveRacune();
                return View("Index", racuni);
            }
            r.Stavke.Add(stavka);

            return RedirectToAction("DetaljiRacuna", new { id = brojRacuna });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}