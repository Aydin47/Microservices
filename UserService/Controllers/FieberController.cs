using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Database;
using UserService.Database.Entities;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieberController : ControllerBase
    {
        // GET: api/Fieber
       [HttpGet]
       public String Get()
       {
           return "Fieber Service";
       }

        // GET: api/Fieber/38
       [HttpGet("{id}", Name = "GetUser")]
       public String Get(int id)
       {
            if (id < 37.5)
            {
                return "No Fieber with " + id + " Celsius";
            }
            else return "Fieber with " + id + " Celsius";
            
       }
    }
}
