using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [Route("api/wetter/[controller]")]
    [ApiController]
    public class WetterController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        // GET: api/Wetter
        [HttpGet]
        public IEnumerable<WeatherForecasts> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 20).Select(index => new WeatherForecasts
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        // GET: api/Wetter/5
        [HttpGet("{id}", Name = "GetWetter")]
        public string Get(int id)
        {
            return "ok";
        }

        // POST: api/Wetter
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Wetter/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
