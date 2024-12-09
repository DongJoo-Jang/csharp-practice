using Microsoft.AspNetCore.Mvc;

namespace HelloAsp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            string userid = Request.Query["userid"];
            string age = Request.Query["age"];
            return $"응답입니다.{userid}_{age}";
        }

        public IActionResult Test()
        {
            return View();
        }

    }
}
