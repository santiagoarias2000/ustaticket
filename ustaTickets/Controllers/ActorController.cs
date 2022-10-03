using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ustaTickets.Data;

namespace ustaTickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allActors = await _context.Actor.ToListAsync();
            return View(allActors);
        }
    }
}
