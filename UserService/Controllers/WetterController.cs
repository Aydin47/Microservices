using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Database.Entities;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WetterController : ControllerBase
    {
        // GET: api/Wetter
        [HttpGet]
        public String Get()
        {
            return "To farenhite/celsius";
        }

        // GET: api/Wetter/27/F or api/Wetter/27/C
        [HttpGet("{id}/{temp}", Name = "GetWetter")]
        public string Get(int id, string temp)
        {
            WeatherForecasts wetter = new WeatherForecasts();
            if (temp == "C") 
            {
                wetter.TemperatureC = id;
                return wetter.TemperatureF.ToString();
            }
            else if (temp == "F") 
            {
                wetter.TemperatureC = (int)((id - 32) * 0.5556) + 1;
                if (wetter.TemperatureF == id)
                {
                    return wetter.TemperatureC.ToString();
                }
                else return "ERROR start from 32";
            } 
            else return "ERROR on temp";
        }
    }
}