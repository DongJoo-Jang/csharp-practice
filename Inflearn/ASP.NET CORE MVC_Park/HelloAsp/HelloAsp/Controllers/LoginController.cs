using BusinessLayer.Services;
using HelloAsp.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HelloAsp.Controllers
{
    public class LoginController : Controller
    {
        private ILoginService IoginService { get; set; }


        public LoginController(ILoginService service)
        {
            IoginService = service;
        }
        public IActionResult NewUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDTO createUserDTO)
        {
            await IoginService.CreateUser(createUserDTO);
            return RedirectToAction("Index","Home");
        }
    }
}
