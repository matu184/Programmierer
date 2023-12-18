using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Programmierer.Models;
using System.Diagnostics;

namespace Programmierer.Controllers
{


    public class HomeController : Controller
    {
        private List<string> Projekte = new List<string> { "Webanwendung", "WPF Anwendungen ", "JavaScript lernen", "C# Vertiefung", "Pause" };
        private List<string> Aufgaben = new List<string> { "Programmieren", "Testen", "Dokumentieren", "Pause" };
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Projekte"] = new SelectList(Projekte);
            ViewData["Aufgaben"] = new SelectList(Aufgaben);

            return View(new Programmer());
        }
        [HttpPost]
        public IActionResult Index(Programmer neu)
        {

            return View(neu);
        }


    }
}
