using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class RandevumsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RandevumsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Randevums
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Randevum.Include(r => r.Kategorim);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Randevums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var randevum = await _context.Randevum
                .Include(r => r.Kategorim)
                .FirstOrDefaultAsync(m => m.RandevuId == id);
            if (randevum == null)
            {
                return NotFound();
            }

            return View(randevum);
        }

        // GET: Randevums/Create
        public IActionResult Create()
        {
            ViewData["KategoriId"] = new SelectList(_context.Kategoris, "KategoriId", "KategoriId");
           
            return View();
        }

        // POST: Randevums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RandevuId,İstekleriniz,Tarih,KategoriId")] Randevum randevum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(randevum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KategoriId"] = new SelectList(_context.Kategoris, "KategoriId", "KategoriId", randevum.KategoriId);
            return View(randevum);
        }

        // GET: Randevums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var randevum = await _context.Randevum.FindAsync(id);
            if (randevum == null)
            {
                return NotFound();
            }
            ViewData["KategoriId"] = new SelectList(_context.Kategoris, "KategoriId", "KategoriId", randevum.KategoriId);
            return View(randevum);
        }

        // POST: Randevums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RandevuId,İstekleriniz,Tarih,KategoriId")] Randevum randevum)
        {
            if (id != randevum.RandevuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(randevum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RandevumExists(randevum.RandevuId))
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
            ViewData["KategoriId"] = new SelectList(_context.Kategoris, "KategoriId", "KategoriId", randevum.KategoriId);
            return View(randevum);
        }

        // GET: Randevums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var randevum = await _context.Randevum
                .Include(r => r.Kategorim)
                .FirstOrDefaultAsync(m => m.RandevuId == id);
            if (randevum == null)
            {
                return NotFound();
            }

            return View(randevum);
        }

        // POST: Randevums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var randevum = await _context.Randevum.FindAsync(id);
            _context.Randevum.Remove(randevum);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RandevumExists(int id)
        {
            return _context.Randevum.Any(e => e.RandevuId == id);
        }
    }
}
