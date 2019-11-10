using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final.Data;
using Final.Models;

namespace Final.Controllers
{
    public class DragonsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DragonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dragons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dragon.ToListAsync());
        }
        public async Task<IActionResult> SearchFor( string searchFor)
        {
           
             searchFor= "Acid";
            

             if (searchFor == null)
             {
                 return NotFound();
             }

            var dragon1 = _context.Dragon.Where(m => m.Element.Contains(searchFor)).ToList();
            if (dragon1 == null)
            {
                return NotFound();
            }

            return View(dragon1);
        }
        // GET: Dragons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dragon = await _context.Dragon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dragon == null)
            {
                return NotFound();
            }

            return View(dragon);
        }

        // GET: Dragons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dragons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,BodyType,Element,Age,IsSlain")] Dragon dragon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dragon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dragon);
        }

        // GET: Dragons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dragon = await _context.Dragon.FindAsync(id);
            if (dragon == null)
            {
                return NotFound();
            }
            return View(dragon);
        }

        // POST: Dragons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,BodyType,Element,Age,IsSlain")] Dragon dragon)
        {
            if (id != dragon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dragon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DragonExists(dragon.Id))
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
            return View(dragon);
        }

        // GET: Dragons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dragon = await _context.Dragon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dragon == null)
            {
                return NotFound();
            }

            return View(dragon);
        }

        // POST: Dragons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dragon = await _context.Dragon.FindAsync(id);
            _context.Dragon.Remove(dragon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DragonExists(int id)
        {
            return _context.Dragon.Any(e => e.Id == id);
        }
    }
}
