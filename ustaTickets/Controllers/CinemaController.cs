using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ustaTickets.Data;

namespace ustaTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CinemaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Cinema.ToListAsync();
            return View(data);
        }
    }
}
