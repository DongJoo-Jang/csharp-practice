using Microsoft.AspNetCore.Mvc;

namespace HelloAsp.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string userid)
        {
            return $"응답입니다.{userid}";
        }
    }
}
