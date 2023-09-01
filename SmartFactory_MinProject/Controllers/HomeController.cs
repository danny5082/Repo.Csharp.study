using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFactory_MinProject.Models;
using System.Diagnostics;

namespace SmartFactory_MinProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly CodeboardDbContext _context;

        public HomeController(CodeboardDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var codeboard = await _context.Codeboard.ToListAsync<Codeboard>();
            return View(codeboard);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Codeboard codeboard)
        {
            if (ModelState.IsValid)
            {
                await _context.Codeboard.AddAsync(codeboard);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(codeboard);
        
        }
        public IActionResult Details(int? id)
        {
            if (id == null || _context.Codeboard == null)
            {
                return NotFound();
            }
            var codeboard = _context.Codeboard.FirstOrDefault(x => x.Id == id);

            if (codeboard == null)
            {
                return NotFound();
            }
            return View(codeboard);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || _context.Codeboard == null)
            {
                return NotFound();
            }
            var codeboard = _context.Codeboard.Find(id);

            if (codeboard == null)
            {
                return NotFound();
            }
            return View(codeboard);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Codeboard std)
        {
            if (ModelState.IsValid)
            {
                _context.Update(std);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(std);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || _context.Codeboard == null)
            {
                return NotFound();
            }
            var stdData = _context.Codeboard.FirstOrDefault(x => x.Id == id);

            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            var stdData = _context.Codeboard.Find(id);

            if (stdData != null)
            {
                _context.Codeboard.Remove(stdData);
            }
            _context.SaveChanges();
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