using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC_Diary.Models;

namespace WebAppMVC_Diary.Controllers
{
    public class HomeController : Controller
    {
        private readonly DiarycontextDB context;
        public HomeController(DiarycontextDB context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var Diarys = context.Diarys.ToList();
            return View(Diarys);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        // POST: 삽입기능
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("No,Name,Content,Date")] Diarys Diarys)
        {
            if (ModelState.IsValid)
            {
                context.Add(Diarys);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Diarys);
        }

        public IActionResult Saved()
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