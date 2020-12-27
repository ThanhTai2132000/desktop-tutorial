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
    public class PhoneTypeListAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public PhoneTypeListAPIController(DPContext context)
        {

            _context = context;
        }
        // GET: api/<PhoneTypeListController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        public string GetPhoneTypeList()
        {
            var listDDT = _context.DongDienThoai;
            var listDDTNew = from p in _context.DongDienThoai
                              select p;

            return JsonConvert.SerializeObject(listDDTNew);
        }

        // GET api/<PhoneTypeListController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PhoneTypeListController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PhoneTypeListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PhoneTypeListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
