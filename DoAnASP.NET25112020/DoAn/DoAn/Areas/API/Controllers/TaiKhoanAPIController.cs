using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoAn.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TaiKhoanAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public TaiKhoanAPIController(DPContext context)
        {
            _context = context;
        }
        // GET: api/<TaiKhoanAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TaiKhoanAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //Lấy tk
        public string TaiKhoanList()
        {
            var listTaiKhoan = _context.TaiKhoan;
            var listTaiKhoanNew = from p in _context.TaiKhoan
                                  select p;

            return JsonConvert.SerializeObject(listTaiKhoanNew);
        }

        // POST api/<TaiKhoanAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaiKhoanAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaiKhoanAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
