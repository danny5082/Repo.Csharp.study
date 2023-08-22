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
        public IActionResult Index(DateTime number1)
        {
            DateTime number2 = @DateTime.Now;
            ViewBag.Plus = (number2 - number1).ToString("dd");
            return View();
        }

    }
}
