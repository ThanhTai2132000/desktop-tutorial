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
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;
using DoAn.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using DoAn.Areas.Admin.Models;
using Newtonsoft.Json;


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
            /*JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
            TaiKhoanModel TK = new TaiKhoanModel();
            TK.TenTK = us.SelectToken("TenTK").ToString();
            TK.MatKhau = us.SelectToken("MatKhau").ToString();
            TK.LoaiTK = Int32.Parse(us.SelectToken("LoaiTK").ToString());*/
            return View(/*TK*/);
        }
        public IActionResult List(string? id)
        {
         
            ViewBag.DongDienThoai = _context.DongDienThoai.ToList(); 
            var list = from m in _context.DienThoai select m;
            if (id != null) list = list.Where(m => m.MaDongDT.Contains(id));
            return View(list.ToList());
        }
        public IActionResult Grid(string? id)
        {
            ViewBag.DongDienThoai = _context.DongDienThoai.ToList();
            var list = from m in _context.DienThoai select m;
            if (id != null) list = list.Where(m => m.MaDongDT.Contains(id));
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
