using Microsoft.AspNetCore.Mvc;
using MVC_Uvod.Models;

namespace MVC_Uvod.Controllers
{
    public class OsobaController : Controller
    {
        [HttpGet]
        public IActionResult Index(Osoba o)
        {
            return View(o);
        }

        public string GetPodatak()
        {
            string pod = "";
            var query = Request.QueryString;
            if (query.HasValue)
            {
                pod = Request.Query["Dob"].ToString();
                pod += Request.Query["Pocetak"].ToString() + " do " + Request.Query["Kraj"].ToString();
            }
            return pod;
        }
        
        public string CookiePrijenos()
        {
            Response.Cookies.Append("Ime", "Ivan", new CookieOptions() { Expires = DateTime.Now.AddYears(1) });
            return "Cookie definiran";
        }

        public string ProcitajIme()
        {
            string cookie = "";
            if (Request.Cookies["Ime"] != null)
            {
                cookie = Request.Cookies["Ime"].ToString();
            }
            Response.Cookies.Delete("Ime");
            return cookie;
            
        }

        [HttpPost]
        public IActionResult OsobaPost()
        {
            var formstring = Request.Form;

            Osoba o = new Osoba();
            o.Ime = formstring["Ime"];
            o.Prezime = formstring["Prezime"];
            o.DatumRodjenja = DateTime.Parse(formstring["DatumRodjenja"]);

            return View("Index",o);
        }
    }
}
