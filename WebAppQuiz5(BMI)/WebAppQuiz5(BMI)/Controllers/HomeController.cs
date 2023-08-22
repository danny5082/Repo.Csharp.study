using Microsoft.AspNetCore.Mvc;

namespace WebAppQuiz3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int number1 ,int number2 ,string number3)
        {
            if(number3 == "남자")
            {
                double a = (number1 * 0.01) * (number1 * 0.01) * 22;
                double b = (number2 / a) * 100;
                if (b < 90)
                {
                    ViewBag.Plus = "저체중";
                }
                else if (b < 110)
                {
                    ViewBag.Plus = "정상체중";
                }
                else if (b < 120)
                {
                    ViewBag.Plus = "과체중";
                }
                else if (b < 130)
                {
                    ViewBag.Plus = "경도비만";
                }
                else if (b < 160)
                {
                    ViewBag.Plus = "중도비만";
                }
                else if (b > 160)
                {
                    ViewBag.Plus = "고도비만";
                }
            }
            if (number3 == "여자")
            {
                double a = (number1 * 0.01) * (number1 * 0.01) * 21;
                double b = (number2 / a) * 100;
                if (b < 90)
                {
                    ViewBag.Plus = "저체중";
                }
                else if (b < 110)
                {
                    ViewBag.Plus = "정상체중";
                }
                else if (b < 120)
                {
                    ViewBag.Plus = "과체중";
                }
                else if (b < 130)
                {
                    ViewBag.Plus = "경도비만";
                }
                else if (b < 160)
                {
                    ViewBag.Plus = "중도비만";
                }
                else if (b > 160)
                {
                    ViewBag.Plus = "고도비만";
                }
            }

            return View();
        }

    }
}
