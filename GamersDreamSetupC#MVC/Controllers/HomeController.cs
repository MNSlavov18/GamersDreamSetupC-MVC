using GamersDreamSetupC_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamersDreamSetupC_MVC.Controllers
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
        public IActionResult Games()
        {
            return View();
        }
        public IActionResult CreateEditGames()
        {
            return View();
        }

        public IActionResult CreateEditGamesForm(Game model)
        {
            return RedirectToAction("Games");
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
    }
}
