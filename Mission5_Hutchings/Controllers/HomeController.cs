using Microsoft.AspNetCore.Mvc;
using Mission5_Hutchings.Models;
using System.Diagnostics;

namespace Mission5_Hutchings.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action to display the Index view
        public IActionResult Index()
        {
            return View();
        }

        // Action to display the Hobby view
        public IActionResult Hobby()
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
