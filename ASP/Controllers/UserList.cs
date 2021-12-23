using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Class;

namespace ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserList : ControllerBase
    {
        static List<UserClass> ListOfUsers = new List<UserClass>();
        [HttpGet("{id}")]
        public string GetUser(int id)
        {
            string Output = "Not found";
            if ((id < ListOfUsers.Count) && (id >= 0))
                Output = JsonConvert.SerializeObject(ListOfUsers[id]);
            Console.WriteLine($"User № {id} : {Output}");
            return Output;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserClass user)
        {
            if (user == null)
                return BadRequest();
            ListOfUsers.Add(user);
            Console.WriteLine($"User {user} is registered");
            return new OkResult();
        }
    }
}
