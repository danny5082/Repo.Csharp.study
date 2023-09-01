using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppQuiz6_snil_.Models;

namespace WebAppQuiz6_snil_.Controllers
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

        public ActionResult About(int selectedSize)
        {
            ViewBag.SelectedSize = selectedSize;
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
    }
}