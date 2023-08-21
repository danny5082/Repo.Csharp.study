using Microsoft.AspNetCore.Mvc;

namespace WebMVCEmpt1.Controllers
{

    //[Route("Home")]
    [Route("[Controller]")]
    public class HomeController : Controller
    {
        [Route("[action]")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

    }
}
