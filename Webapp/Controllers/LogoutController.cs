using Microsoft.AspNetCore.Mvc;
using Webapp.Helpers.Services;

namespace Webapp.Controllers
{
    public class LogoutController : Controller
    {
        private readonly AuthenticationService _authenticationService;

        public LogoutController(AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<IActionResult> Index()
        {
            if (await _authenticationService.LogoutAsync())
                return RedirectToAction("Index", "Home");
            return View();
        }   
    }
}
