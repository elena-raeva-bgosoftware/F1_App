using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Web_App.Data;
using F1_Web_App.Models;
using Microsoft.AspNetCore.Authorization;
using F1_Web_App.Data.Models;

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

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = _context.Drivers
                .Where(p => p.Id == id)
                .Select(p => new DriverEditViewModel
                {
                    Id = p.Id,
                    DriverNumber = p.DriverNumber,
                    TeamId = p.TeamId,
                    ImageUrl = p.ImageUrl,
                    Teams = _context.Teams
                        .Select(t => new TeamListViewModel
                        {
                            TeamName = t.Name
                        })
                        .ToList()
                });

            return View(model);
        }

        //[Authorize]
        //[HttpPost]
        //public async Task<IActionResult> Edit(DriverEditViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        model.Categories = await context.Categories
        //         .Select(c => new CategoryViewModel
        //         {
        //             Id = c.Id,
        //             Name = c.Name
        //         })
        //         .ToListAsync();
        //        return View(model);
        //    }

        //    string userId = GetUserId();
        //    var entity = context.Products
        //        .Where(p => p.Id == model.Id)
        //       .FirstOrDefault();

        //    entity.ProductName = model.ProductName;
        //    entity.Description = model.Description;
        //    entity.Price = model.Price;
        //    entity.ImageUrl = model.ImageUrl;
        //    entity.CategoryId = model.CategoryId;
        //    entity.AddedOn = DateTime.Parse(model.AddedOn);
        //    context.SaveChanges();
        //    return RedirectToAction("Details", new { id = model.Id });

        //}
    }
}
