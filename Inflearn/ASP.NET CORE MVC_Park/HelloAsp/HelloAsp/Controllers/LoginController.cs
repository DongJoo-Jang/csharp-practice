using HelloAsp.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HelloAsp.Controllers
{
    public class LoginController : Controller
    {


        public IActionResult NewUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(CreateUserDTO createUserDTO)
        {
            return View();
        }
    }
}
