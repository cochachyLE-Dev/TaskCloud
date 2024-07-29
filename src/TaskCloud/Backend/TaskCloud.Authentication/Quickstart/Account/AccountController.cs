using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaskCloud.Authentication.Quickstart.UI.Account
{
    [AllowAnonymous]
    public class AccountController: Controller
    {
        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl)
        {            
            ViewData["ReturnUrl"] = returnUrl;

            return View(new LoginViewModel { });
        }        
    }
}
