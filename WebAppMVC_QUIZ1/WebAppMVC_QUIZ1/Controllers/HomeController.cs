using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC_QUIZ1.Models;

namespace WebAppMVC_QUIZ1.Controllers
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
        [HttpPost]
        public IActionResult Result(string v1 , string v2)
        {
            ViewBag.data1 = v1;
            ViewBag.data2 = v2;
            //ViewData
            //ViewBag
            //TempData
            //Strongly Typed View


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