using F1_Web_App.Data; 
using F1_Web_App.Models; 
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace F1_Web_App.Controllers
{
    public class StandingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StandingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult ListDriverStandings()
        {
            var currentYear = DateTime.Now.Year;

            var standings = _context.Drivers
                .Join(
                    _context.Results,
                    driver => driver.Id,
                    result => result.DriverId,
                    (driver, result) => new
                    {
                        driver.DriverNumber,
                        driver.Name,
                        result.Points,
                        result.Event.EventDate 
                    }
                )
                .Where(x => x.EventDate.Year == currentYear) 
                .GroupBy(x => new { x.DriverNumber, x.Name }) 
                .Select(group => new StandingsViewModel
                {
                    DriverNumber = group.Key.DriverNumber,
                    DriverName = group.Key.Name,
                    TotalPoints = group.Sum(g => g.Points)
                })
                .OrderByDescending(x => x.TotalPoints) 
                .ToList();

            return View(standings); 
        }
    }
}
