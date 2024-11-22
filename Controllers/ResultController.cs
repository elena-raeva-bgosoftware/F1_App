using F1_Web_App.Data;
using F1_Web_App.Data.Models;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace F1_Web_App.Controllers
{
    public class ResultController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResultController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync(int EventId)
        {
            var model = await _context.Results
                .Where(r => r.EventId == EventId)
                .Select(r => new ResultViewModel
                {
                    Id = r.Id,
                    DriverName = r.Driver.Name,
                    DriverNumber = r.Driver.DriverNumber,
                    TeamName = r.Driver.Team.Name,
                    Points = r.Points
                })
                
                .FirstOrDefaultAsync();

            return View(model);
        }
    }
}
