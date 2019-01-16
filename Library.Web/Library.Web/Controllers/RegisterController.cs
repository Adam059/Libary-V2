using Library.Web.Entities;
using Library.Web.Infrastructure;
using Library.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly LibraryContext _context;

        public RegisterController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterDto model)
        {
            if (model.Password != model.ConfirmPassword)
                return View("Register", new RegisterDto());

            var newUser = new User
            {
                Name = model.Name,
                Password = model.Password
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();
            return View("Index");
        }
    }
}