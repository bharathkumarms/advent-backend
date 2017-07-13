using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using js.advent.model;

namespace js.advent.webapi.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        //// GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/login/5
        [HttpGet("{id}")]
        public bool Get(int id)
        {
            //var validUsers = new List<User>();
            //var user1 = new User();
            //user1.UserName = "bharath";
            //user1.Password = "test123";
            //validUsers.Add(user1);

            return true;
            
        }

        // POST api/values
        [HttpPost]
        public User Post([FromBody]string value)
        {
            var user1 = new User();
            user1.firstName = "bharath";
            user1.lastName = "test123";
            user1.userName = "test";
            user1.id = 1;
            return user1;
        }

        /*// PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
