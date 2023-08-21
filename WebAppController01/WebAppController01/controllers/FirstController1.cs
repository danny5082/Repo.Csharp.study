using Microsoft.AspNetCore.Mvc;

namespace WebAppController01.controllers
{
    public class FirstController1 : Controller
    {
        [Route("First")]
        public IActionResult first()
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
