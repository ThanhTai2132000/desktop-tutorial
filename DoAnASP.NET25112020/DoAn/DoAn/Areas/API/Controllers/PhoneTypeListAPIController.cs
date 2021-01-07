using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> ThanhTai
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
<<<<<<< HEAD
                              select p;
=======
                             select p;
>>>>>>> ThanhTai

            return JsonConvert.SerializeObject(listDDTNew);
        }

<<<<<<< HEAD
        // GET api/<PhoneTypeListController>/5
=======
        // GET api/<PhoneTypeListAPIController>/5
>>>>>>> ThanhTai
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

<<<<<<< HEAD
        // POST api/<PhoneTypeListController>
=======
        // POST api/<PhoneTypeListAPIController>
>>>>>>> ThanhTai
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

<<<<<<< HEAD
        // PUT api/<PhoneTypeListController>/5
=======
        // PUT api/<PhoneTypeListAPIController>/5
>>>>>>> ThanhTai
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

<<<<<<< HEAD
        // DELETE api/<PhoneTypeListController>/5
=======
        // DELETE api/<PhoneTypeListAPIController>/5
>>>>>>> ThanhTai
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
