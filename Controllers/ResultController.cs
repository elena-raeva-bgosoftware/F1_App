using F1_Web_App.Data;
using F1_Web_App.Data.Models;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace F1_Web_App.Controllers
{
    public class ResultController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResultController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("Results/List/{EventId}")]
        public async Task<IActionResult> IndexAsync(int EventId)
        {
            try
            {
                var data = _context.Events
                .Include(e => e.Circuit)
                .Include(e => e.Results)
                .ThenInclude(r => r.Driver)
                .ThenInclude(d => d.Team)
                .Where(e => e.Id == EventId)
                .FirstOrDefault();
                var model = new ResultListViewModel
                {
                    CircuitName = data.Circuit.Name,
                    EventDate = data.EventDate,
                    Results = 
                    data.Results.Select(r => new ResultViewModel
                    {
                        Id = r.Id,
                        DriverName = r.Driver.Name,
                        DriverNumber = r.Driver.DriverNumber,
                        TeamName = r.Driver.Team.Name,
                        Points = r.Points,

                    }).OrderByDescending(r => r.Points)
                    .ThenBy(r => r.DriverName)
                    .ToList()
                    
                };


                return View("/Views/Results/List.cshtml", model);
            }
            catch (Exception e)
            {

                throw;
            }
            
        }
    }
}
