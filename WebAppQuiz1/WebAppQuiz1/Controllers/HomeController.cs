using Microsoft.AspNetCore.Mvc;

namespace WebAppQuiz1.Controllers
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
