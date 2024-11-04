using Microsoft.AspNetCore.Mvc;
using F1_App.Data;
using System.Linq;

namespace F1_App.Controllers
{
    public class TracksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TracksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tracks = _context.Tracks.ToList();
            return View(tracks);
        }
    }
}
