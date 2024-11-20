using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Web_App.Data;
using F1_Web_App.Models;

namespace F1_Web_App.Controllers
{
    public class DriversController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DriversController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ListDrivers()
        {
            var model = await _context.Drivers
                .Select(d => new DriverListViewModel
                {
                    Id = d.Id,
                    DriverNumber = d.DriverNumber,
                    Name = d.Name,
                    TeamName = d.Team.Name,
                    ImageUrl = d.ImageUrl
                })
                .ToListAsync();

            return View(model);
        }
    }
}
