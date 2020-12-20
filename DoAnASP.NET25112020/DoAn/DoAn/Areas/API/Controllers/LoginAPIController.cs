using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Areas.Admin.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoAn.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginAPIController : ControllerBase
    {
        private readonly DPContext _context;
        
        public LoginAPIController(DPContext context)
        {
            _context = context;
        }
        // GET: api/<LoginAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public string GetAccount(string username, string password)
        {
            var account = _context.TaiKhoan
                .FirstOrDefault(m => m.TenTK == username && m.MatKhau == password);
            if (account != null)
            {
                if (account.LoaiTK == 0)
                {
                    var str = JsonConvert.SerializeObject(account);
                    HttpContext.Session.SetString("account", str);
                }
                
            }
            return JsonConvert.SerializeObject(account);
        }

        // GET api/<LoginAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoginAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
