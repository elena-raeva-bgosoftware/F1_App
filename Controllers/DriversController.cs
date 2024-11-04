using Microsoft.AspNetCore.Mvc;
using F1_App.Data;
using System.Linq;

namespace F1_App.Controllers
{
    public class DriversController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DriversController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var drivers = _context.Drivers.ToList();
            return View(drivers);
        }
    }
}
