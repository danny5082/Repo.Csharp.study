using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_MVC_Typed.Models;

namespace WebApp_MVC_Typed.Controllers
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
            Employee obj = new Employee()
            {
                EmpId = 100,
                EmpName = "홍딜동",
                Designation = "대리",
                Salary = 25000
            };

            //ViewBag.Employee = obj;
            //ViewData["data1"] = obj;
            //TempData["data1"] = obj;
            return View(obj);



            //var myEmployees = new List<Employee>
            //{
            //    new Employee {EmpId = 100,EmpName = "홍길동", Designation = "대리",Salary = 30000 },
            //    new Employee {EmpId = 200,EmpName = "이순신", Designation = "부장",Salary = 60000 },
            //    new Employee {EmpId = 300,EmpName = "강감찬", Designation = "상무",Salary = 70000 }
            //};
            //return View(myEmployees);
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