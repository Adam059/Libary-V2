using Library.Data;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LendingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LendingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}