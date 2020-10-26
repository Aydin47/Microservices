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
    [Route("api/ok/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       private readonly DataBaseContext db = new DataBaseInstance();
        
        // GET: api/User
       [HttpGet]
       public IEnumerable<User> Get()
       {
           return db.user.ToList();
       }
    
       // GET: api/User/5
       [HttpGet("{id}", Name = "GetUser")]
       public User Get(int id)
       {
            return db.user.Find(id);
       }
     
        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            try
            {
                db.user.Add(model);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
