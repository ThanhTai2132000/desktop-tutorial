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
        
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
