using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoAn.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WeatherAPIController : ControllerBase
    {
        // GET: api/<WeatherAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public string GetWeatherCurrent()
        {
            string id = "1566083"; //id cua TP HCM
            string appid = "3f588b971dc0d537f8a1cf855af6f854"; //API key (token)
            string lang = "vi";

            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}&lang={2}", id, appid, lang);


            WebClient client = new WebClient();

            var result = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<Object>(result);



            return JsonConvert.SerializeObject(data);
        }

        // GET api/<WeatherAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WeatherAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WeatherAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WeatherAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
