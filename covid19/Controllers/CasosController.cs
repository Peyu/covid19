using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using covid19.Models;

namespace covid19.Controllers
{
    public class CasosController : Controller
    {
        private readonly covidBDContext _context;

        public CasosController(covidBDContext context)
        {
            _context = context;
        }

        // GET: Casos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Casos.ToListAsync());
        }

        // GET: Casos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casos = await _context.Casos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (casos == null)
            {
                return NotFound();
            }

            return View(casos);
        }

        // GET: Casos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Casos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Provincia_Id,Activos,Recuperados,Muertes")] Casos casos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(casos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(casos);
        }

        // GET: Casos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casos = await _context.Casos.FindAsync(id);
            if (casos == null)
            {
                return NotFound();
            }
            return View(casos);
        }

        // POST: Casos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Provincia_Id,Activos,Recuperados,Muertes")] Casos casos)
        {
            if (id != casos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(casos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CasosExists(casos.Id))
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
            return View(casos);
        }

        // GET: Casos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casos = await _context.Casos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (casos == null)
            {
                return NotFound();
            }

            return View(casos);
        }

        // POST: Casos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var casos = await _context.Casos.FindAsync(id);
            _context.Casos.Remove(casos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CasosExists(int id)
        {
            return _context.Casos.Any(e => e.Id == id);
        }
    }
}
