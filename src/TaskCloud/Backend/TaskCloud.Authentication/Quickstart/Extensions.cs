using Microsoft.AspNetCore.Mvc;

using TaskCloud.Authentication.Quickstart.UI.Account;

namespace TaskCloud.Authentication.Quickstart
{
    public static class Extensions
    {
        public static IActionResult LoadingPage(this Controller controller, string viewName, string redirectUri)
        {
            controller.HttpContext.Response.StatusCode = 200;
            controller.HttpContext.Response.Headers["Location"] = "";

            return controller.View(viewName, new RedirectViewModel { RedirectUrl = redirectUri });
        }
    }
}
