using Microsoft.AspNetCore.Mvc;

namespace WebAppQuiz2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
