using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Areas.Admin.Data;
using DoAn.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace DoAn.Controllers
{
    public class LoginController : Controller
    {


        public ActionResult Index()
        {
            //ViewBag.UserName = Convert.ToString(Session["UserName"]);
            return View();
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
