using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inquiry_System.Models;

namespace Inquiry_System.Controllers
{
    public class PlaneTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlaneTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlaneTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlaneTypes.ToListAsync());
        }

        // GET: PlaneTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planeType = await _context.PlaneTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planeType == null)
            {
                return NotFound();
            }

            return View(planeType);
        }

        // GET: PlaneTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlaneTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Description")] PlaneType planeType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planeType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planeType);
        }

        // GET: PlaneTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planeType = await _context.PlaneTypes.FindAsync(id);
            if (planeType == null)
            {
                return NotFound();
            }
            return View(planeType);
        }

        // POST: PlaneTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Description")] PlaneType planeType)
        {
            if (id != planeType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planeType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaneTypeExists(planeType.Id))
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
            return View(planeType);
        }

        // GET: PlaneTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planeType = await _context.PlaneTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planeType == null)
            {
                return NotFound();
            }

            return View(planeType);
        }

        // POST: PlaneTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planeType = await _context.PlaneTypes.FindAsync(id);
            if (planeType != null)
            {
                _context.PlaneTypes.Remove(planeType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaneTypeExists(int id)
        {
            return _context.PlaneTypes.Any(e => e.Id == id);
        }
    }
}
