﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using F1_Web_App.Data;
using F1_Web_App.Data.Models;
using F1_Web_App.Models;

namespace F1_Web_App.Controllers
{
    public class CalendarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalendarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ParticipationViewModels
        public async Task<IActionResult> List()
        {
            var model = await _context.CircuitSeasons
                    .Include(cs => cs.Circuit)
                .Select(p => new CircuitSeasonViewModel
                {
                    Id = p.Id,
                    CircuitName = p.Circuit.Name,
                    RaceDate = p.Date, ImageUrl = p.Circuit.ImageUrl
                })
                .Distinct()
                .ToListAsync();

            return View(model);
        }

    }
}