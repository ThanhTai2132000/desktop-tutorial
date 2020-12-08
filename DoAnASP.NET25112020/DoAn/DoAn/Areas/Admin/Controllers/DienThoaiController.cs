﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAn.Areas.Admin.Data;
using DoAn.Areas.Admin.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace DoAn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DienThoaiController : Controller
    {
        private readonly DPContext _context;

        public DienThoaiController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/DienThoai
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.DienThoai.Include(d => d.DongDT);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/DienThoai/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienThoaiModel = await _context.DienThoai
                .Include(d => d.DongDT)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dienThoaiModel == null)
            {
                return NotFound();
            }

            return View(dienThoaiModel);
        }

        // GET: Admin/DienThoai/Create
        public IActionResult Create()
        {
            ViewData["MaDongDT"] = new SelectList(_context.DongDienThoai, "MaDT", "MaDT");
            return View();
        }

        // POST: Admin/DienThoai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TenDT,MaDongDT,Hinh,DonGia,GiaKM")] DienThoaiModel dienThoaiModel , IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dienThoaiModel);
                await _context.SaveChangesAsync();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pro", dienThoaiModel.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                dienThoaiModel.Hinh = dienThoaiModel.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(dienThoaiModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaDongDT"] = new SelectList(_context.DongDienThoai, "MaDT", "MaDT", dienThoaiModel.MaDongDT);
            return View(dienThoaiModel);
        }

        // GET: Admin/DienThoai/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienThoaiModel = await _context.DienThoai.FindAsync(id);
            if (dienThoaiModel == null)
            {
                return NotFound();
            }
            ViewData["MaDongDT"] = new SelectList(_context.DongDienThoai, "MaDT", "MaDT", dienThoaiModel.MaDongDT);
            return View(dienThoaiModel);
        }

        // POST: Admin/DienThoai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TenDT,MaDongDT,Hinh,DonGia,GiaKM")] DienThoaiModel dienThoaiModel)
        {
            if (id != dienThoaiModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dienThoaiModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DienThoaiModelExists(dienThoaiModel.ID))
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
            ViewData["MaDongDT"] = new SelectList(_context.DongDienThoai, "MaDT", "MaDT", dienThoaiModel.MaDongDT);
            return View(dienThoaiModel);
        }

        // GET: Admin/DienThoai/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dienThoaiModel = await _context.DienThoai
                .Include(d => d.DongDT)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dienThoaiModel == null)
            {
                return NotFound();
            }

            return View(dienThoaiModel);
        }

        // POST: Admin/DienThoai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dienThoaiModel = await _context.DienThoai.FindAsync(id);
            _context.DienThoai.Remove(dienThoaiModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DienThoaiModelExists(int id)
        {
            return _context.DienThoai.Any(e => e.ID == id);
        }
    }
}
