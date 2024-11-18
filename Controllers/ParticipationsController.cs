using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Web_App.Data;
using F1_Web_App.Data.Models;
using F1_Web_App.Models;

namespace F1_Web_App.Controllers
{
    public class ParticipationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParticipationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ParticipationViewModels
        public async Task<IActionResult> ListParticipation()
        {
            var model = await _context.CircuitSeasons
                    .Include(cs => cs.Circuit)
                    .ThenInclude(t => t.Country)
                .Select(p => new ParticipationListViewModel
                {
                    Id = p.Id,
                    CircuitName = p.Circuit.Name,
                    RaceDate = p.Date, ImageUrl = p.Circuit.ImageUrl
                })
                .Distinct()
                .ToListAsync();

            return View(model);
        }

    }
}
