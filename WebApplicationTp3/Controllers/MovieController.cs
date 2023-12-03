﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movie.Models;
using WebApplicationTp3.Models;

namespace TP3.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Movie.Include(m => m.Genres);
            return View(await applicationDbContext.ToListAsync());
        }



        public IActionResult Create()
        {
            ViewData["Genresid"] = new SelectList(_context.Genre, "Id", "Id");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Genresid,date,ImageURL,formFile")] Movie movies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Genresid"] = new SelectList(_context.Genre, "Id", "Id", movies.Genresid);
            return View(movies);
        }
    }
}