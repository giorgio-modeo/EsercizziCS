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
    public class PrestitoesController : Controller
    {
        private readonly Core_PrestitiVideotecaContext _context;

        public PrestitoesController(Core_PrestitiVideotecaContext context)
        {
            _context = context;
        }

        // GET: Prestitoes
        public async Task<IActionResult> Index()
        {
            var core_PrestitiVideotecaContext = _context.Prestitos.Include(p => p.IdFilmNavigation).Include(p => p.MatricolaNavigation);
            return View(await core_PrestitiVideotecaContext.ToListAsync());
        }

        // GET: Prestitoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Prestitos == null)
            {
                return NotFound();
            }

            var prestito = await _context.Prestitos
                .Include(p => p.IdFilmNavigation)
                .Include(p => p.MatricolaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestito == null)
            {
                return NotFound();
            }

            return View(prestito);
        }

        // GET: Prestitoes/Create
        public IActionResult Create()
        {
            ViewData["IdFilm"] = new SelectList(_context.Films, "Codice", "Codice");
            ViewData["Matricola"] = new SelectList(_context.Studentes, "Matricola", "Matricola");
            return View();
        }

        // POST: Prestitoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdFilm,Matricola,DataPrestito,DataRestituzione")] Prestito prestito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdFilm"] = new SelectList(_context.Films, "Codice", "Codice", prestito.IdFilm);
            ViewData["Matricola"] = new SelectList(_context.Studentes, "Matricola", "Matricola", prestito.Matricola);
            return View(prestito);
        }

        // GET: Prestitoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Prestitos == null)
            {
                return NotFound();
            }

            var prestito = await _context.Prestitos.FindAsync(id);
            if (prestito == null)
            {
                return NotFound();
            }
            ViewData["IdFilm"] = new SelectList(_context.Films, "Codice", "Codice", prestito.IdFilm);
            ViewData["Matricola"] = new SelectList(_context.Studentes, "Matricola", "Matricola", prestito.Matricola);
            return View(prestito);
        }

        // POST: Prestitoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdFilm,Matricola,DataPrestito,DataRestituzione")] Prestito prestito)
        {
            if (id != prestito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestitoExists(prestito.Id))
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
            ViewData["IdFilm"] = new SelectList(_context.Films, "Codice", "Codice", prestito.IdFilm);
            ViewData["Matricola"] = new SelectList(_context.Studentes, "Matricola", "Matricola", prestito.Matricola);
            return View(prestito);
        }

        // GET: Prestitoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Prestitos == null)
            {
                return NotFound();
            }

            var prestito = await _context.Prestitos
                .Include(p => p.IdFilmNavigation)
                .Include(p => p.MatricolaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestito == null)
            {
                return NotFound();
            }

            return View(prestito);
        }

        // POST: Prestitoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Prestitos == null)
            {
                return Problem("Entity set 'Core_PrestitiVideotecaContext.Prestitos'  is null.");
            }
            var prestito = await _context.Prestitos.FindAsync(id);
            if (prestito != null)
            {
                _context.Prestitos.Remove(prestito);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestitoExists(int id)
        {
          return (_context.Prestitos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
