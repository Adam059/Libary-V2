using Library.Web.Entities;
using Library.Web.Infrastructure;
using Library.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Library.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly LibraryContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RegisterController(LibraryContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;            
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