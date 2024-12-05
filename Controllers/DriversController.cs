﻿using Microsoft.AspNetCore.Mvc;
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
          //TODO: try using attribute to validate role   [Authorize(Roles = "Administrator, Moderator")]
            if (!User.IsInRole("Administrator"))
            {
                return Unauthorized();
            }

            var model = await _context.Drivers
                .Where(p => p.Id == id)
                .Select(p => new DriverEditViewModel
                {
                    Id = p.Id,
                    DriverName = p.Name,
                    DriverNumber = p.DriverNumber,
                    TeamId = p.TeamId,
                    ImageUrl = p.ImageUrl,
                    Teams = _context.Teams
                        .Select(t => new TeamListViewModel
                        {
                            TeamId = t.Id,
                            TeamName = t.Name
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            if (model == null)
            {
                return NotFound();
            }
       // TODO: Remove this check, add default value in view model -> new List
            if (model.Teams == null)
            {
                model.Teams = new List<TeamListViewModel>();
            }

            return View(model);

        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, DriverEditViewModel model)
        {
          //TODO: try using attribute to validate role   [Authorize(Roles = "Administrator, Moderator")]
            if (!User.IsInRole("Administrator"))
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                model.Teams = _context.Teams
                    .Select(t => new TeamListViewModel
                    {
                        TeamId = t.Id,
                        TeamName = t.Name
                    })
                    .ToList();
   // TODO: Remove this check, add default value in view model -> new List
                if (model.Teams == null)
                {
                    model.Teams = new List<TeamListViewModel>();
                }
                return View(model);
            }

            var driver = await _context.Drivers.FindAsync(id);

            if (driver == null)
            {
                return BadRequest();
            }

            driver.Name = model.DriverName;
            driver.DriverNumber = model.DriverNumber;
            driver.TeamId = model.TeamId;
            driver.ImageUrl = model.ImageUrl;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(ListDrivers));

        }

        [Authorize]
        [HttpGet]
        public IActionResult CreateDriver()
        {
          //TODO: try using attribute to validate role   [Authorize(Roles = "Administrator, Moderator")]
            if (!User.IsInRole("Administrator"))
            {
                return Unauthorized();
            }
         
            var model = new DriverEditViewModel
            {
                Teams = _context.Teams
                    .Select(t => new TeamListViewModel
                    {
                        TeamId = t.Id,
                        TeamName = t.Name
                    })
                    .ToList()
            };

            return View("CreateDriver", model); 
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateDriver(DriverEditViewModel model)
        {
          //TODO: try using attribute to validate role   [Authorize(Roles = "Administrator, Moderator")]
            if (!User.IsInRole("Administrator"))
            {
                return Unauthorized();
            }
//TODO: chcek is there is a already a driver with the same number
            if (!ModelState.IsValid)
            {   
                model.Teams = _context.Teams
                    .Select(t => new TeamListViewModel
                    {
                        TeamId = t.Id,
                        TeamName = t.Name
                    })
                    .ToList();

                return View(model);
            }

            var driver = new Driver
            {
                Name = model.DriverName,
                DriverNumber = model.DriverNumber,
                TeamId = model.TeamId,
                ImageUrl = model.ImageUrl
            };

            _context.Drivers.Add(driver);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(ListDrivers));
        }

        [Authorize]
        [HttpGet]
        public IActionResult ConfirmDeleteDriver(int id)
        {
          //TODO: try using attribute to validate role   [Authorize(Roles = "Administrator, Moderator")]
            if (!User.IsInRole("Administrator"))
            {
                return Unauthorized();
            }

            var driver = _context.Drivers
                .Select(d => new DriverListViewModel
                {
                    Id = d.Id,
                    DriverNumber = d.DriverNumber,
                    Name = d.Name,
                    TeamName = d.Team.Name,
                    ImageUrl = d.ImageUrl
                })
                .FirstOrDefault(d => d.Id == id);

            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        [Authorize]
        [HttpPost]
        public IActionResult DeleteDriver(int id)
        {
            if (!User.IsInRole("Administrator"))
            {
                return Unauthorized();
            }

            var driver = _context.Drivers.Find(id);
            if (driver == null)
            {
                return NotFound();
            }

            _context.Drivers.Remove(driver);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Driver deleted successfully.";

            return RedirectToAction("ListDrivers");
        }


        [Authorize(Roles = "Administrator, Moderator")]
        [HttpPost]
        public async Task<IActionResult> ToggleDriverStatus(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver == null)
            {
                return NotFound();
            }

            driver.IsRetired = !driver.IsRetired;
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = $"Driver status updated to {(driver.IsRetired ? "Retired" : "Active")}.";

            var drivers = await _context.Drivers.ToListAsync();
            var driverListViewModels = drivers.Select(d => new DriverListViewModel
            {
                Id = d.Id,
                DriverNumber = d.DriverNumber,
                Name = d.Name,
                TeamName = d.Team?.Name,
                ImageUrl = d.ImageUrl,
                IsRetired = d.IsRetired
            }).ToList();

            return View("ListDrivers", driverListViewModels);
        }


        [Authorize(Roles = "Administrator, Moderator")]
        public async Task<IActionResult> StatusActiveOrAllDrivers(bool showActiveOnly = false)
        {
          //TODO: call to list after the if, to avoid unacesary items to be loaded from db
            var drivers = await _context.Drivers.ToListAsync();
            if (showActiveOnly)
            {
                drivers = drivers.Where(d => !d.IsRetired).ToList();
            }

            var driverListViewModels = drivers.Select(d => new DriverListViewModel
            {
                Id = d.Id,
                DriverNumber = d.DriverNumber,
                Name = d.Name,
                TeamName = d.Team?.Name,
                ImageUrl = d.ImageUrl,
                IsRetired = d.IsRetired
            }).ToList();

            ViewBag.ShowActiveOnly = showActiveOnly;
            return View(driverListViewModels);
        }
    }
}
