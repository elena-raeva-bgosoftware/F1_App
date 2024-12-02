using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Web_App.Data;
using F1_Web_App.Data.Models;
using F1_Web_App.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace F1_Web_App.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> List(int? year)
        {
            var eventsQuery = _context.Events.AsQueryable();

            if (year.HasValue)
            {
                eventsQuery = eventsQuery.Where(e => e.EventDate.Year == year.Value);
            }

            var model = await eventsQuery
                .Select(p => new EventViewModel
                {
                    Id = p.Id,
                    CircuitName = p.Circuit.Name,
                    Country = p.Circuit.Country.Name,
                    EventDate = p.EventDate,
                    ImageUrl = p.Circuit.ImageUrl
                })
                .ToListAsync();

            var years = await _context.Events
                .Select(e => e.EventDate.Year)
                .Distinct()
                .OrderBy(y => y)
                .ToListAsync();

            ViewBag.Years = new SelectList(years);

            return View(model);
        }
    }
}
