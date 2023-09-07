using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFactory_MinProject.Models;
using System.Diagnostics;

namespace SmartFactory_MinProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CodeboardDbContext _context;

        public HomeController(ILogger<HomeController> logger, CodeboardDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Login()
        {

            if (HttpContext.Session.GetString("UserSession") != null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("UserSession").ToString();
            }

            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var myUser = _context.User.Where(
                x => x.AccountId == user.AccountId &&
                     x.AccountPassword == user.AccountPassword)
                .FirstOrDefault();

            if (myUser != null)
            {
                HttpContext.Session.SetString("UserSession", myUser.AccountId);
                HttpContext.Session.SetString("UserName", myUser.Name);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "아이디 혹은 비밀번호가 일치하지 않습니다.";
            }

            return View();
        }


        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                HttpContext.Session.Remove("UserName");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            var myUser = _context.User.Where(
                x => x.AccountId == user.AccountId)
                .FirstOrDefault();

            if (myUser == null)
            {
                if (ModelState.IsValid)
                {
                    await _context.User.AddAsync(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Login", "Home");
                }
                return View(user);
            }
            else
            {
                ViewBag.Message = "중복된 아이디가 존재합니다.";

                return View();
            }
        }



        public async Task<IActionResult> Index(string searchTerm)
        {
            if (HttpContext.Session.GetString("UserSession") == null)
            {
                return RedirectToAction("Login");
            }

            var codeboard = await _context.Codeboard.ToListAsync();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                codeboard = codeboard.Where(c => c.Title.Contains(searchTerm) || c.Name.Contains(searchTerm)).ToList();
            }

            ViewBag.MySession = HttpContext.Session.GetString("UserName").ToString();
            return View(codeboard);
        }




        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("UserName").ToString();
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Codeboard codeboard)
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("UserSession").ToString();
            }

            if (ModelState.IsValid)
            {
                await _context.Codeboard.AddAsync(codeboard);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(codeboard);

        }

        [HttpPost]
        public IActionResult DeleteComment(int commentId)
        {
            var comment = _context.Comments.Find(commentId);
            if (comment != null)
            {
                _context.Comments.Remove(comment);
                _context.SaveChanges();
            }

            return RedirectToAction("Details", new { id = comment.CodeboardId });
        }








        public IActionResult Details(int? id)
        {
            if (id == null || _context.Codeboard == null)
            {
                return NotFound();
            }
            var codeboard = _context.Codeboard
                .Include(c => c.Comments) 
                .FirstOrDefault(x => x.Id == id);

            if (codeboard == null)
            {
                return NotFound();
            }

            return View(codeboard);
        }



        [HttpPost]
        public IActionResult AddComment(int id, string content)
        {
            var codeboard = _context.Codeboard.Find(id);

            if (content != null)
            {

                if (codeboard != null)
                {
                    var comment = new Comment
                    {
                        Content = content,
                        Date = DateTime.Now,
                        CodeboardId = id
                    };

                    _context.Comments.Add(comment);
                    _context.SaveChanges();
                }

            }
            return RedirectToAction("Details", new { id });

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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}