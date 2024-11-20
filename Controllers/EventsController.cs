using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Web_App.Data;
using F1_Web_App.Data.Models;
using F1_Web_App.Models;

namespace F1_Web_App.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> List()
        {
            var model = await _context.Events
                .Select(p => new EventViewModel
                {
                    Id = p.Id,
                    CircuitName = p.Circuit.Name,
                    Country = p.Circuit.Country.Name,
                    EventDate = p.EventDate,
                    ImageUrl = p.Circuit.ImageUrl
                })
                .Distinct()
                .ToListAsync();

            return View(model);
        }

    }
}
