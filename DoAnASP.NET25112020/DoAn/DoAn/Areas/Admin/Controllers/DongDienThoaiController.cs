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
    public class DongDienThoaiController : Controller
    {
        private readonly DPContext _context;

        public DongDienThoaiController(DPContext context)
        {

            _context = context;
        }

        // GET: Admin/DongDienThoai
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



            return View(await _context.DongDienThoai.ToListAsync());
        }

        // GET: Admin/DongDienThoai/Details/5
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

            var dongDienThoaiModel = await _context.DongDienThoai
                .FirstOrDefaultAsync(m => m.MaDT == id);
            if (dongDienThoaiModel == null)
            {
                return NotFound();
            }

            return View(dongDienThoaiModel);
        }

        // GET: Admin/DongDienThoai/Create
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

        // POST: Admin/DongDienThoai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDT,TenDongDT")] DongDienThoaiModel dongDienThoaiModel)
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
                _context.Add(dongDienThoaiModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dongDienThoaiModel);
        }

        // GET: Admin/DongDienThoai/Edit/5
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

            var dongDienThoaiModel = await _context.DongDienThoai.FindAsync(id);
            if (dongDienThoaiModel == null)
            {
                return NotFound();
            }
            return View(dongDienThoaiModel);
        }

        // POST: Admin/DongDienThoai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaDT,TenDongDT")] DongDienThoaiModel dongDienThoaiModel)
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




            if (id != dongDienThoaiModel.MaDT)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dongDienThoaiModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DongDienThoaiModelExists(dongDienThoaiModel.MaDT))
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
            return View(dongDienThoaiModel);
        }

        // GET: Admin/DongDienThoai/Delete/5
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

            var dongDienThoaiModel = await _context.DongDienThoai
                .FirstOrDefaultAsync(m => m.MaDT == id);
            if (dongDienThoaiModel == null)
            {
                return NotFound();
            }

            return View(dongDienThoaiModel);
        }

        // POST: Admin/DongDienThoai/Delete/5
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



            var dongDienThoaiModel = await _context.DongDienThoai.FindAsync(id);
            _context.DongDienThoai.Remove(dongDienThoaiModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DongDienThoaiModelExists(string id)
        {
            return _context.DongDienThoai.Any(e => e.MaDT == id);
        }
    }
}
