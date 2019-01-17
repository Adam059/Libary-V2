using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Library.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
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

            CookieOptions option = new CookieOptions
            {
                Expires = DateTime.Now.AddMinutes(120)
            };
            Response.Cookies.Append("pwd", model.Password, option);
            Response.Cookies.Append("name", model.Name, option);
            return RedirectToAction("Index", "Book");
        }
    }
}