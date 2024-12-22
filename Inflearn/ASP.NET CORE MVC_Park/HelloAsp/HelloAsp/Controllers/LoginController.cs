using BusinessLayer.Services;
using HelloAsp.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HelloAsp.Controllers
{
    public class LoginController : Controller
    {
        private ILoginService IoginService { get; set; }


        public LoginController()
        {
            IoginService = new LoginService();
        }
        public IActionResult NewUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(CreateUserDTO createUserDTO)
        {
            IoginService.CreateUser(createUserDTO);
            return View();
        }
    }
}
