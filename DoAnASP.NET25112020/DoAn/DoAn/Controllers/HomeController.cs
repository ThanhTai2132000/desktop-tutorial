using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DoAn.Models;
using DoAn.Areas.Admin.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;

        public HomeController(DPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var list = from m in _context.DienThoai select m;
            return View(list.ToList());
        }
        public IActionResult Grid()
        {
            var list = from m in _context.DienThoai select m;
            return View(list.ToList());
        }
        public  async Task <IActionResult> Details(int? id)
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
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
