using Microsoft.AspNetCore.Mvc;

namespace HelloAsp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string userId , int age)
        {
            return Redirect("/Home/Test") ;
        }

        public IActionResult Test()
        {

            ViewData["MyMsg"] = "Hello response";
            var list = new List<string> { "abc","kim","lee"};
            return View(list);
        }

    }
}
