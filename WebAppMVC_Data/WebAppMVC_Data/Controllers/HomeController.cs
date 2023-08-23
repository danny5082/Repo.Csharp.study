using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC_Data.Models;

namespace WebAppMVC_Data.Controllers
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
        public IActionResult About()
        {
            TempData.Keep("data3");
            return View();
        }

        public IActionResult UseViewBag()
        {
            ViewBag.data1 = "홍길동";
            ViewBag.data2 = 100;
            TempData["data3"] = "강감찬";
            ViewBag.data3 = DateTime.Now.ToShortTimeString();
            string[] arr = {"사과", "딸기", "배"};
            ViewBag.data4 = arr;

            ViewBag.data5 = new List<string>
            {
                "축구","농구","야구"
            };
            TempData.Keep("data3");
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