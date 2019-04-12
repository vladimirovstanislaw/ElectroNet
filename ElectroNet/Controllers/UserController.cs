using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectroNet.Dao;
using ElectroNet.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectroNet.Controllers
{
    [Route("api/")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("get/{id}", Name = "Get")]
        public User Get(int id)
        {
            return UserDao.getInstance().getUser(id);
        }

        // POST: api/User
        [HttpPost("post")]
        public void Post([FromBody] User usr)
        {
            UserDao.getInstance().AddUser(usr);
        }

        // PUT: api/User/5
        [HttpPatch("patch{id}", Name = "Patch")]
        public void Put(int id, [FromBody] User usr)
        {
            if (id == usr.Id)
            {
                UserDao.getInstance().patchUser(usr);
            }
            
        }
    }
}
