using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final.Data;
using Final.Models;
using Amazon.OpsWorks.Model;

namespace Final.Controllers
{
    public class KnightsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KnightsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Knights
        public async Task<IActionResult> Index()
        {
            return View(await _context.Knight.ToListAsync());
        }

        // GET: Knights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knight = await _context.Knight
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knight == null)
            {
                return NotFound();
            }

            return View(knight);
        }

        // GET: Knights/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Knights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Male,Female,WeaponOfChoice,Email,Age")] Knight knight)
        {
            if (ModelState.IsValid)
            {
                _context.Add(knight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(knight);
        }

        // GET: Knights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knight = await _context.Knight.FindAsync(id);
            if (knight == null)
            {
                return NotFound();
            }
            return View(knight);
        }
        public string FindEvenId(int id)
        {
            var knight =_context.Knight.FindAsync(id);
            /*App.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "FirstEvenRecord",
                    pattern: "{controller=Knights}/{action=FirstEvenRecord}/{id?}");
                endpoints.MapRazorPages();
            });
            */
            

            // this is where you put your magic code
            return knight.ToString();
        }


        // POST: Knights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Male,Female,WeaponOfChoice,Email,Age")] Knight knight)
        {
            if (id != knight.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(knight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KnightExists(knight.Id))
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
            return View(knight);
        }

        // GET: Knights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knight = await _context.Knight
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knight == null)
            {
                return NotFound();
            }

            return View(knight);
        }

        // POST: Knights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var knight = await _context.Knight.FindAsync(id);
            _context.Knight.Remove(knight);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KnightExists(int id)
        {
            return _context.Knight.Any(e => e.Id == id);
        }
    }
}
