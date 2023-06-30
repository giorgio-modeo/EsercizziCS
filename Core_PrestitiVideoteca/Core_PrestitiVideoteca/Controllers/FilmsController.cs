using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core_PrestitiVideoteca.Models;

namespace Core_PrestitiVideoteca.Controllers
{
    public class FilmsController : Controller
    {
        private readonly Core_PrestitiVideotecaContext _context;

        public FilmsController(Core_PrestitiVideotecaContext context)
        {
            _context = context;
        }

        // GET: Films
        public async Task<IActionResult> Index(int? numeroPerPagina)
        {
            var lista = _context.Films.IgnoreQueryFilters();
            if (numeroPerPagina != null)
                lista = _context.Films.Take((int)numeroPerPagina);
            return _context.Films != null ?
                          View(await _context.Films.ToListAsync()) :
                          Problem("Entity set 'Core_PrestitiVideotecaContext.Films'  is null.");
        }

        // GET: Films/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Films == null)
            {
                return NotFound();
            }

            var film = await _context.Films
                .FirstOrDefaultAsync(m => m.Codice == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // GET: Films/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codice,Titolo,Supporto,Regista,Attori,Genere")] Film film)
        {
            if (ModelState.IsValid)
            {
                _context.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        // GET: Films/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Films == null)
            {
                return NotFound();
            }

            var film = await _context.Films.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Codice,Titolo,Supporto,Regista,Attori,Genere")] Film film)
        {
            if (id != film.Codice)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(film.Codice))
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
            return View(film);
        }

        // GET: Films/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Films == null)
            {
                return NotFound();
            }

            var film = await _context.Films
                .FirstOrDefaultAsync(m => m.Codice == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Films == null)
            {
                return Problem("Entity set 'Core_PrestitiVideotecaContext.Films'  is null.");
            }
            var film = await _context.Films.FindAsync(id);
            if (film != null)
            {
                _context.Films.Remove(film);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CercaTitolo(string searchQuery)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return RedirectToAction(nameof(Index));
            }
            var films = await _context.Films
                .Where(f => f.Titolo.Contains(searchQuery))
                .ToListAsync();
            return View("Index", films);
        }
        public async Task<IActionResult> CercaAttore(string searchQuery)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return RedirectToAction(nameof(Index));
            }
            var films = await _context.Films
                .Where(f => f.Attori.Contains(searchQuery))
                .ToListAsync();
            return View("Index", films);
        }

        private bool FilmExists(int id)
        {
          return (_context.Films?.Any(e => e.Codice == id)).GetValueOrDefault();
        }
    }
}
