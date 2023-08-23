using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC_Model1.Models;

namespace WebAppMVC_Model1.Controllers
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
            var st1 = new StudentModel()
            {
                ID = 1,
                Name = "오동용",
                num = 01040975082,
                Age = 23
            };
            //ViewData["student"] = st1;
            ViewBag.Student = st1;
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