using Library.Web.Infrastructure;
using Library.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Library.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly LibraryContext _context;

        public LoginController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(new LoginDto());
        }

        [HttpPost]
        public IActionResult Login(LoginDto model)
        {
            var isUserCorrect = _context.Users.Where(x => x.Password == model.Password && x.Name == model.Name).Any();
            if (!isUserCorrect)
                return RedirectToAction("FailedLogin", "Error");

            return RedirectToAction("Index", "Book");
        }
    }
}