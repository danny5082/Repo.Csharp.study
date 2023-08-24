using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC_Model3.Models;

namespace WebAppMVC_Model3.Controllers
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
            var cars = new List<Car>()
            {
                new Car {ID = 1 , Brand = "BMW" , speed = "240Km/h"},
                new Car {ID = 2 , Brand = "audi" , speed = "280Km/h"},
                new Car {ID = 3 , Brand = "benz" , speed = "260Km/h"},
            };

            ViewData["data1"] = cars;
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