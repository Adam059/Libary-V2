using Library.Web.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class LendingsController : Controller
    {
        private readonly LibraryContext _context;
        public LendingsController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}