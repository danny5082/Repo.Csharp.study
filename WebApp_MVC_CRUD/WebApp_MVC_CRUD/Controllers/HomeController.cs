using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApp_MVC_CRUD.Models;

namespace WebApp_MVC_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext context;
        public HomeController(StudentDbContext context)
        {
            this.context = context;
        }

       

        public IActionResult Index()
        {
            var students = context.Student.ToList();
            return View(students);
        }
        //get화면
        public IActionResult Create()
        {

            return View();
        }
        // POST: 삽입기능
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Hp")] Student student)
        {
            if (ModelState.IsValid)
            {
                context.Add(student);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
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