using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoAn.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PhoneListAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public PhoneListAPIController(DPContext context)
        {

            _context = context;
        }
        // GET: api/<PhoneListAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        public string GetPhoneList()
        {
            var listDT = _context.DienThoai.Include(d => d.DongDT);
            var listDTNew = (from p in _context.DienThoai
                             join l in _context.DongDienThoai on p.MaDongDT equals l.MaDT
                             select new { 
                                p.ID,
                                p.TenDT,
                                p.MaDongDT,
                                p.Hinh,
                                p.DonGia,
                                p.GiaKM,
                                l.MaDT,
                                l.TenDongDT
                             }).OrderBy(x=>x.ID);

            return JsonConvert.SerializeObject(listDTNew);
        }

        // GET api/<PhoneListAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PhoneListAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PhoneListAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PhoneListAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
