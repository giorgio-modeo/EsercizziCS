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
    public class StudentiController : Controller
    {
        private readonly Core_PrestitiVideotecaContext _context;

        public StudentiController(Core_PrestitiVideotecaContext context)
        {
            _context = context;
        }

        // GET: Studenti
        public async Task<IActionResult> Index()
        {
              return _context.Studentes != null ? 
                          View(await _context.Studentes.ToListAsync()) :
                          Problem("Entity set 'Core_PrestitiVideotecaContext.Studenti'  is null.");
        }

        // GET: Studenti/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Studentes == null)
            {
                return NotFound();
            }

            var studente = await _context.Studentes
                .FirstOrDefaultAsync(m => m.Matricola == id);
            if (studente == null)
            {
                return NotFound();
            }

            return View(studente);
        }

        // GET: Studenti/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studenti/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Matricola,Nome,Cognome,Email,Classe")] Studente studente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studente);
        }

        // GET: Studenti/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Studentes == null)
            {
                return NotFound();
            }

            var studente = await _context.Studentes.FindAsync(id);
            if (studente == null)
            {
                return NotFound();
            }
            return View(studente);
        }

        // POST: Studenti/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Matricola,Nome,Cognome,Email,Classe")] Studente studente)
        {
            if (id != studente.Matricola)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudenteExists(studente.Matricola))
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
            return View(studente);
        }

        // GET: Studenti/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Studentes == null)
            {
                return NotFound();
            }

            var studente = await _context.Studentes
                .FirstOrDefaultAsync(m => m.Matricola == id);
            if (studente == null)
            {
                return NotFound();
            }

            return View(studente);
        }

        // POST: Studenti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Studentes == null)
            {
                return Problem("Entity set 'Core_PrestitiVideotecaContext.Studentes'  is null.");
            }
            var studente = await _context.Studentes.FindAsync(id);
            if (studente != null)
            {
                _context.Studentes.Remove(studente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudenteExists(int id)
        {
          return (_context.Studentes?.Any(e => e.Matricola == id)).GetValueOrDefault();
        }
    }
}
