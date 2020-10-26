using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entities;

namespace UserService
{
    public class DataBaseInstance : DataBaseContext
    {
        private readonly DataBaseContext db;
        public DataBaseInstance()
        {
            db = new DataBaseContext();
        }


    }
}
