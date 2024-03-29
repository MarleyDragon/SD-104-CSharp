﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CatDragonInnWebApp.Data;
using CatDragonInnWebApp.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace CatDragonInnWebApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _env;

        public ProductsController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;


        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,Image,Genre,ProductDescription,ReleaseDate,Creator,Publisher,FileUpload")] Product product, IFormFile file)
        {
            if (file != null)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = _env.WebRootPath + "\\uploads\\ProductImages\\" + fileName;

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                product.Image = "uploads/ProductImages/" + fileName;
            }
            if (file != null)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = _env.WebRootPath + "\\uploads\\ProductFiles\\" + fileName;

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                product.FileUpload = "uploads/ProductFiles/" + fileName;
            }
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,ProductName,Image,Genre,ProductDescription,ReleaseDate,Creator,Publisher,FileUpload")] Product product, IFormFile file)
        {
            if (file != null)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = _env.WebRootPath + "\\uploads\\ProductImages\\" + fileName;

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                product.Image = "uploads/ProductImages/" + fileName;
            }
                if (file != null)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = _env.WebRootPath + "\\uploads\\ProductFiles\\" + fileName;

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    product.FileUpload = "uploads/ProductFiles/" + fileName;
                }
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
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
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductID == id);
        }
    }
}
