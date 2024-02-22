using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Doors2Heaven.Data;
using Doors2Heaven.Models;

namespace Doors2Heaven.Controllers
{
    public class DoorsController : Controller
    {
        private readonly Doors2HeavenContext _context;

        public DoorsController(Doors2HeavenContext context)
        {
            _context = context;
        }

        // GET: Doors
        /*public async Task<IActionResult> Index()
        {
            return View(await _context.Doors.ToListAsync());
        }*/
        public async Task<IActionResult> Index(string movieGenre, string searchString)
        {
            if (_context.Doors == null)
            {
                return Problem("Entity set 'DoorsContext.Doors'  is null.");
            }

            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Doors
                                            orderby m.Material
                                            select m.Material;
            var movies = from m in _context.Doors
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Types_of_Door!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Material == movieGenre);
            }

            var movieGenreVM = new DoorMaterialViewModel
            {
                Material = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Doors = await movies.ToListAsync()
            };

            return View(movieGenreVM);
        }

        // GET: Doors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doors = await _context.Doors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doors == null)
            {
                return NotFound();
            }

            return View(doors);
        }

        // GET: Doors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Doors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Types_of_Door,Style_of_Door,Features,Price,Material,Ratings")] Doors doors)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doors);
        }

        // GET: Doors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doors = await _context.Doors.FindAsync(id);
            if (doors == null)
            {
                return NotFound();
            }
            return View(doors);
        }

        // POST: Doors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Types_of_Door,Style_of_Door,Features,Price,Material,Ratings")] Doors doors)
        {
            if (id != doors.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoorsExists(doors.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(doors);
        }

        // GET: Doors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doors = await _context.Doors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doors == null)
            {
                return NotFound();
            }

            return View(doors);
        }

        // POST: Doors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doors = await _context.Doors.FindAsync(id);
            if (doors != null)
            {
                _context.Doors.Remove(doors);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoorsExists(int id)
        {
            return _context.Doors.Any(e => e.Id == id);
        }
    }
}