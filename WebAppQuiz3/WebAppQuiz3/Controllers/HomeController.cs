using Microsoft.AspNetCore.Mvc;

namespace WebAppQuiz3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int number1, int number2)
        {
            ViewBag.Plus = number1 + number2;
            ViewBag.Minus = number1 - number2;
            ViewBag.gop = number1 * number2;
            ViewBag.na = number1 / number2;

            return View();
        }
        
    }
}
