using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing;
using WebApp_ModelBinding01.Models;

namespace WebApp_ModelBinding01.Controllers
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

        public string About(int id , string name , string hp)
        {
            return "ID : " + id +  " Name :" + name + " Hp : " + hp;
        }

        [HttpPost]
        public string Index(Student st)
        {
            return "ID : " + st.Id + "Name :" + st.Name + "Hp : " + st.Hp;
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