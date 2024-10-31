using GamersDreamSetupC_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamersDreamSetupC_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly GamersDreamDBContext _context;

        public HomeController(ILogger<HomeController> logger, GamersDreamDBContext context)
        {
            _logger = logger;
            _context = context; 
        }

        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Games()
        {
            var allGames = _context.Games.ToList();
            return View(allGames);
        }
        public IActionResult CreateEditGames()
        {
            return View();
        }

        public IActionResult CreateEditGamesForm(Game model)
        {
            _context.Games.Add(model);

            _context.SaveChanges();

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
