using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAn.Areas.Admin.Data;
using DoAn.Areas.Admin.Models;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;

namespace DoAn.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoaDonController : Controller
    {
        private readonly DPContext _context;

        public HoaDonController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/HoaDon
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



            return View(await _context.HoaDon.ToListAsync());
        }

        // GET: Admin/HoaDon/Details/5
        public async Task<IActionResult> Details(string id)
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

            var hoaDonModel = await _context.HoaDon
                .FirstOrDefaultAsync(m => m.MaHD == id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return View(hoaDonModel);
        }

        // GET: Admin/HoaDon/Create
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



            return View();
        }

        // POST: Admin/HoaDon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHD,MaTK,NgayLapHD,TongTien")] HoaDonModel hoaDonModel)
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
                _context.Add(hoaDonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hoaDonModel);
        }

        // GET: Admin/HoaDon/Edit/5
        public async Task<IActionResult> Edit(string id)
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

            var hoaDonModel = await _context.HoaDon.FindAsync(id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }
            return View(hoaDonModel);
        }

        // POST: Admin/HoaDon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaHD,MaTK,NgayLapHD,TongTien")] HoaDonModel hoaDonModel)
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



            if (id != hoaDonModel.MaHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDonModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonModelExists(hoaDonModel.MaHD))
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
            return View(hoaDonModel);
        }

        // GET: Admin/HoaDon/Delete/5
        public async Task<IActionResult> Delete(string id)
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

            var hoaDonModel = await _context.HoaDon
                .FirstOrDefaultAsync(m => m.MaHD == id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return View(hoaDonModel);
        }

        // POST: Admin/HoaDon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
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



            var hoaDonModel = await _context.HoaDon.FindAsync(id);
            _context.HoaDon.Remove(hoaDonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonModelExists(string id)
        {
            return _context.HoaDon.Any(e => e.MaHD == id);
        }
    }
}
