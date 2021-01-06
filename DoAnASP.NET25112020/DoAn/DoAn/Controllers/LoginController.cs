using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Areas.Admin.Data;
using DoAn.Areas.Admin.Models;
using Microsoft.AspNetCore.Http; //để truy xuất gán và lấy Session thông qua đối tượng Json
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DoAn.Controllers
{
    public class LoginController : Controller
    {
        private readonly DPContext _context;
        public LoginController(DPContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind("Username,Password")] TaiKhoanModel taikhoan)
        {
            var r = _context.TaiKhoan.Where(m => (m.TenTK == taikhoan.TenTK && m.MatKhau == 
            StringProcessing.CreateMD5Hash(taikhoan.MatKhau))).ToList();

            if (r.Count == 0)
            {
                return View("Index");
            }
            //Gán Session
            var str = JsonConvert.SerializeObject(taikhoan);
            HttpContext.Session.SetString("user", str);
            if (r[0].LoaiTK == 0)
            {
                var url = Url.RouteUrl("areas", new { controller = "Home", action = "Index", area = "Admin" });
                return Redirect(url);
            }
            return RedirectToAction("Index", "Home");

        }
        public ActionResult Index()
        {
            JObject acc;
            try
            {
                if (HttpContext.Session.GetString("account") != null)
                {
                    acc = JObject.Parse(HttpContext.Session.GetString("account"));
                }else acc = JObject.Parse(HttpContext.Session.GetString("accountuser"));

                ViewBag.account = acc.SelectToken("TenTK").ToString();
                
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index","Home");
            //ViewBag.UserName = Convert.ToString(Session["UserName"]);
        }

        //[HttpPost, ValidateJsonAntiForgeryToken]
        //public JsonResult Login(string name, string email)
        //{
        //    Session["UserName"] = email;
        //    return Json(new { success = "True" });
        //}

        //[HttpPost, ValidateJsonAntiForgeryToken]
        //public JsonResult LogOut()
        //{
        //    Session.Abandon();
        //    return Json(new { success = "True" });
        //}

    }
}
