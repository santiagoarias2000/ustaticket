using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ustaTickets.Data;

namespace ustaTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Movie
                .Include(c=>c.Cinema)
                .OrderBy(c => c.Name)
                .ToListAsync();
            return View(data);
        }
    }
}
