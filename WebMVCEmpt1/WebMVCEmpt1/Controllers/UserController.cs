using Microsoft.AspNetCore.Mvc;

namespace WebMVCEmpt1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
