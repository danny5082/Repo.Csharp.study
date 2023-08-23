using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC_QUIZ2.Models;

namespace WebAppMVC_QUIZ2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int number)
        {
            ViewData["WON"] = number;
            ViewData["EUR"] = number*0.00069;
            ViewData["JPY"] = number*0.11;
            ViewData["CNY"] = number*0.0054;
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