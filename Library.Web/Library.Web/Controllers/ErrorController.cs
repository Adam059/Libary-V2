using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult FailedRegister()
        {
            return View();
        }

        public IActionResult FailedLogin()
        {
            return View();
        }
    }
}