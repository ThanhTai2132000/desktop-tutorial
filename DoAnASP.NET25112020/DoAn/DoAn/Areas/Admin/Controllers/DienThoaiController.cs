using System;
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
using Newtonsoft.Json.Linq;

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
            try
            {
                JObject acc = JObject.Parse(HttpContext.Session.GetString("account"));
                ViewBag.account = acc.SelectToken("TenTK").ToString();
            }
            catch
            {
                return View("../Shared/Error");
            }



            var dPContext = _context.DienThoai.Include(d => d.DongDT);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/DienThoai/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                JObject acc = JObject.Parse(HttpContext.Session.GetString("account"));
                ViewBag.account = acc.SelectToken("TenTK").ToString();
            }
            catch
            {
                return View("../Shared/Error");
            }



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
            try
            {
                JObject acc = JObject.Parse(HttpContext.Session.GetString("account"));
                ViewBag.account = acc.SelectToken("TenTK").ToString();
            }
            catch
            {
                return View("../Shared/Error");
            }



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
            try
            {
                JObject acc = JObject.Parse(HttpContext.Session.GetString("account"));
                ViewBag.account = acc.SelectToken("TenTK").ToString();
            }
            catch
            {
                return View("../Shared/Error");
            }



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
            try
            {
                JObject acc = JObject.Parse(HttpContext.Session.GetString("account"));
                ViewBag.account = acc.SelectToken("TenTK").ToString();
            }
            catch
            {
                return View("../Shared/Error");
            }



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
            try
            {
                JObject acc = JObject.Parse(HttpContext.Session.GetString("account"));
                ViewBag.account = acc.SelectToken("TenTK").ToString();
            }
            catch
            {
                return View("../Shared/Error");
            }



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
            try
            {
                JObject acc = JObject.Parse(HttpContext.Session.GetString("account"));
                ViewBag.account = acc.SelectToken("TenTK").ToString();
            }
            catch
            {
                return View("../Shared/Error");
            }



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
            try
            {
                JObject acc = JObject.Parse(HttpContext.Session.GetString("account"));
                ViewBag.account = acc.SelectToken("TenTK").ToString();
            }
            catch
            {
                return View("../Shared/Error");
            }



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
