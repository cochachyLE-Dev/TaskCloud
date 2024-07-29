using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaskCloud.Authentication.Quickstart.Home
{
    [AllowAnonymous]
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
