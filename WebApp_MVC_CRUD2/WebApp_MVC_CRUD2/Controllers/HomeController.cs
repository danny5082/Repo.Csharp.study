using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApp_MVC_CRUD2.Models;

namespace WebApp_MVC_CRUD2.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly StudentDBContext _context;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(StudentDBContext context)
        {
            _context = context;
        }




        public async Task<IActionResult> Index()
        {
            var students = await _context.Student.ToListAsync<Student>();
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }

        ////비동기 생성
        //[HttpPost]
        //public IActionResult Create(Student std)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Student.Add(std);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View(std);
        //}

        //동기 생성
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
                await _context.Student.AddAsync(std);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(std);
        }
        //동기 상세
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var stdData = await _context.Student.FirstOrDefaultAsync(x => x.Id == id);

            if (stdData == null)
            {
                return NotFound();
            }

            return View(stdData);
        }


        //비동기 수정
        public IActionResult Edit(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }
            var stdData = _context.Student.Find(id);
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        //동기 수정
        [HttpPost]
        public async Task<IActionResult> Edit(int? id, Student std)
        {

            if (ModelState.IsValid)
            {
                //_context.Student.Update(std);
                _context.Update(std);
                _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(std);

        }
        //비동기 삭제
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }
            var stdData = await _context.Student.FirstOrDefaultAsync((x => x.Id == id));

            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        //동기 삭제
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var stdData = await _context.Student.FindAsync(id);
            if (stdData != null)
            {
                _context.Student.Remove(stdData);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
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