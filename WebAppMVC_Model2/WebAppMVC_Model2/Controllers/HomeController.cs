using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC_Model2.Models;
using WebAppMVC_Model2.Repository;

namespace WebAppMVC_Model2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudentModel> getAllStudents()
        {
            return _studentRepository.getAllStudents();
        }
        public StudentModel getById(int id)
        {
            return _studentRepository.getStudentById(id);
        }

        public IActionResult Index()
        {
            //var st = new StudentModel()
            //{
            //    Id = 1,
            //    Name = "홍길동",
            //    HP = "010-1111-1111",
            //    Major = "컴공"
            //};

            //ViewData["data1"] = st;


            //var students = new List<StudentModel>()
            //{
            //    new StudentModel{Id = 1,Name ="홍길동",HP="010-1111-1111",Major="컴공"},
            //    new StudentModel{Id = 2,Name ="강감찬",HP="010-2222-2222",Major="정통"},
            //    new StudentModel{Id = 3,Name ="이순신",HP="010-3333-3333",Major="기계"},
            //    new StudentModel{Id = 4,Name ="김구",HP="010-4444-4444",Major="멀티"}

            //};
            //ViewData["data1"] = students;
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