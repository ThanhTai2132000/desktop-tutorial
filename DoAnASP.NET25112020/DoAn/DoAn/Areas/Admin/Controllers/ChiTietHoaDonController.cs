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
    public class ChiTietHoaDonController : Controller
    {
        private readonly DPContext _context;

        public ChiTietHoaDonController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/ChiTietHoaDon
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



            return View(await _context.ChiTietHoaDon.ToListAsync());
        }

        // GET: Admin/ChiTietHoaDon/Details/5
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

            var chiTietHoaDonModel = await _context.ChiTietHoaDon
                .FirstOrDefaultAsync(m => m.ID == id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDonModel);
        }

        // GET: Admin/ChiTietHoaDon/Create
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

        // POST: Admin/ChiTietHoaDon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MaHoaDon,IDDienThoai,SoLuong,DonGia,GiaKhuyenMai")] ChiTietHoaDonModel chiTietHoaDonModel)
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
                _context.Add(chiTietHoaDonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chiTietHoaDonModel);
        }

        // GET: Admin/ChiTietHoaDon/Edit/5
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

            var chiTietHoaDonModel = await _context.ChiTietHoaDon.FindAsync(id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }
            return View(chiTietHoaDonModel);
        }

        // POST: Admin/ChiTietHoaDon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MaHoaDon,IDDienThoai,SoLuong,DonGia,GiaKhuyenMai")] ChiTietHoaDonModel chiTietHoaDonModel)
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



            if (id != chiTietHoaDonModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHoaDonModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHoaDonModelExists(chiTietHoaDonModel.ID))
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
            return View(chiTietHoaDonModel);
        }

        // GET: Admin/ChiTietHoaDon/Delete/5
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

            var chiTietHoaDonModel = await _context.ChiTietHoaDon
                .FirstOrDefaultAsync(m => m.ID == id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDonModel);
        }

        // POST: Admin/ChiTietHoaDon/Delete/5
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



            var chiTietHoaDonModel = await _context.ChiTietHoaDon.FindAsync(id);
            _context.ChiTietHoaDon.Remove(chiTietHoaDonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHoaDonModelExists(int id)
        {
            return _context.ChiTietHoaDon.Any(e => e.ID == id);
        }
    }
}
