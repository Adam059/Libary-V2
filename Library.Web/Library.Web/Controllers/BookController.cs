using Library.Web.Entities;
using Library.Web.Infrastructure;
using Library.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Linq;

namespace Library.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryContext _context;
        public BookController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var books = _context.Books.Select(x => new BookDto
            {
                Author = x.Author,
                Description = x.Description,
                Name = x.Name
            }).ToList();
            return View(books);
        }
        public IActionResult Create()
        {
            return View(new BookDto());
        }

        [HttpPost]
        public IActionResult Create(BookDto model)
        {
            var user = Request.Cookies["name"];
            var pwd = Request.Cookies["pwd"];
            var userId = _context.Users.Where(x => x.Name == user && x.Password == pwd).Select(x => x.UserId).First();
            var newBook = new Book
            {
                Author = model.Author,
                Description = model.Description,
                Name = model.Name,
                OwnerId = userId
            };
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return View("Index");
        }

        public IActionResult Edit(BookDto model)
        {
            var editedBook = _context.Books.Where(x => x.BookId == model.BookId).First();
            editedBook.Author = model.Author;
            editedBook.Description = model.Description;
            editedBook.Name = model.Name;
            _context.SaveChanges();
            return View();
        }

        public IActionResult Borrow(int bookId)
        {
            var userId = 1; // TODO
            var newLending = new BookLending
            {
                BookId = bookId,
                DateFrom = DateTime.Now,
                DateTo = null,
                OwnerId = userId
            };
            _context.BookLendings.Add(newLending);
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult Release(int bookId)
        {
            var lending = _context.BookLendings.Where(x => x.BookId == bookId).First();
            lending.DateTo = DateTime.Now;
            _context.SaveChanges();
            return Ok();
        }
    }
}