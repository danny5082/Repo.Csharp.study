using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplQuiz6.Models;

namespace WebApplQuiz6.Controllers
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
        public IActionResult Index(Score model)
        {
            Dictionary<string, double> gradeToScore4_5 = new Dictionary<string, double>
{
    {"A+", 4.5 },
    {"A", 4.0 },
    {"B+", 3.5},
    {"B", 3.0},
    {"C+", 2.5 },
    {"C", 2.0},
    {"D+", 1.5},
    {"D", 1.0}
};

            double averageScore4_5 = (gradeToScore4_5[model.rnrdj] +
                                   gradeToScore4_5[model.duddj] +
                                   gradeToScore4_5[model.tngkr] +
                                   gradeToScore4_5[model.tkghl] +
                                   gradeToScore4_5[model.rhkgkr]) / 5;

            ViewData["AverageScore4_5"] = averageScore4_5;

            Dictionary<string, double> gradeToScore100 = new Dictionary<string, double>
{
    {"A+", 100 },
    {"A", 95 },
    {"B+", 90},
    {"B", 85},
    {"C+", 80 },
    {"C", 75},
    {"D+", 70},
    {"D", 65}
};

            double averageScore100 = (gradeToScore100[model.rnrdj] +
                                   gradeToScore100[model.duddj] +
                                   gradeToScore100[model.tngkr] +
                                   gradeToScore100[model.tkghl] +
                                   gradeToScore100[model.rhkgkr]) / 5;

            ViewData["AverageScore100"] = averageScore100;


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