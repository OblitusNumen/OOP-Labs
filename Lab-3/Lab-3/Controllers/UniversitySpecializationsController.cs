using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab_3.Data;
using Lab_3.Models;

namespace Lab_3.Controllers
{
    public class UniversitySpecializationsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public UniversitySpecializationsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: UniversitySpecializations
        public async Task<IActionResult> Index()
        {
            var applicationDBContext = _context.UniversitySpecializations.Include(u => u.Specialization).Include(u => u.University);
            return View(await applicationDBContext.ToListAsync());
        }

        // GET: UniversitySpecializations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universitySpecializations = await _context.UniversitySpecializations
                .Include(u => u.Specialization)
                .Include(u => u.University)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (universitySpecializations == null)
            {
                return NotFound();
            }

            return View(universitySpecializations);
        }

        // GET: UniversitySpecializations/Create
        public IActionResult Create()
        {
            ViewData["SpecId"] = new SelectList(_context.Specialization, "Id", "Id");
            ViewData["UniversityId"] = new SelectList(_context.University, "Id", "Id");
            return View();
        }

        // POST: UniversitySpecializations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UniversityId,SpecId")] UniversitySpecializations universitySpecializations)
        {
            //if (ModelState.IsValid)
            {
                _context.Add(universitySpecializations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SpecId"] = new SelectList(_context.Specialization, "Id", "Id", universitySpecializations.SpecId);
            ViewData["UniversityId"] = new SelectList(_context.University, "Id", "Id", universitySpecializations.UniversityId);
            return View(universitySpecializations);
        }

        // GET: UniversitySpecializations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universitySpecializations = await _context.UniversitySpecializations.FindAsync(id);
            if (universitySpecializations == null)
            {
                return NotFound();
            }
            ViewData["SpecId"] = new SelectList(_context.Specialization, "Id", "Id", universitySpecializations.SpecId);
            ViewData["UniversityId"] = new SelectList(_context.University, "Id", "Id", universitySpecializations.UniversityId);
            return View(universitySpecializations);
        }

        // POST: UniversitySpecializations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UniversityId,SpecId")] UniversitySpecializations universitySpecializations)
        {
            if (id != universitySpecializations.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universitySpecializations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversitySpecializationsExists(universitySpecializations.Id))
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
            ViewData["SpecId"] = new SelectList(_context.Specialization, "Id", "Id", universitySpecializations.SpecId);
            ViewData["UniversityId"] = new SelectList(_context.University, "Id", "Id", universitySpecializations.UniversityId);
            return View(universitySpecializations);
        }

        // GET: UniversitySpecializations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universitySpecializations = await _context.UniversitySpecializations
                .Include(u => u.Specialization)
                .Include(u => u.University)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (universitySpecializations == null)
            {
                return NotFound();
            }

            return View(universitySpecializations);
        }

        // POST: UniversitySpecializations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var universitySpecializations = await _context.UniversitySpecializations.FindAsync(id);
            if (universitySpecializations != null)
            {
                _context.UniversitySpecializations.Remove(universitySpecializations);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversitySpecializationsExists(int id)
        {
            return _context.UniversitySpecializations.Any(e => e.Id == id);
        }
    }
}
