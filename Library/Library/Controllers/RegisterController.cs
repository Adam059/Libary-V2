using Library.Data;
using Library.Entities;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegisterController(ApplicationDbContext context)
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
                return RedirectToAction("FailedRegister", "Error");

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