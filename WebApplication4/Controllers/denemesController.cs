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
    public class denemesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public denemesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: denemes
        public async Task<IActionResult> Index()
        {
            return View(await _context.deneme.ToListAsync());
        }

        // GET: denemes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deneme = await _context.deneme
                .FirstOrDefaultAsync(m => m.RandevuId == id);
            if (deneme == null)
            {
                return NotFound();
            }

            return View(deneme);
        }

        // GET: denemes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: denemes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RandevuId,İstekleriniz,Ad")] deneme deneme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deneme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deneme);
        }

        // GET: denemes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deneme = await _context.deneme.FindAsync(id);
            if (deneme == null)
            {
                return NotFound();
            }
            return View(deneme);
        }

        // POST: denemes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RandevuId,İstekleriniz,Id")] deneme deneme)
        {
            if (id != deneme.RandevuId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deneme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!denemeExists(deneme.RandevuId))
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
            return View(deneme);
        }

        // GET: denemes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deneme = await _context.deneme
                .FirstOrDefaultAsync(m => m.RandevuId == id);
            if (deneme == null)
            {
                return NotFound();
            }

            return View(deneme);
        }

        // POST: denemes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deneme = await _context.deneme.FindAsync(id);
            _context.deneme.Remove(deneme);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool denemeExists(int id)
        {
            return _context.deneme.Any(e => e.RandevuId == id);
        }
    }
}
