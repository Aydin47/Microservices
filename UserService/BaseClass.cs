using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entities;

namespace UserService
{
    public class BaseClass : ControllerBase
    {
        protected readonly DataBaseContext db;
        public BaseClass()
        {
            db = new DataBaseInstance();
        }
    }
}
