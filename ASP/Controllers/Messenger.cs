using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Class;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Messanger : ControllerBase
    {
        static List<MessageClass> ListOfMessages = new List<MessageClass>();

        [HttpGet("{id}")]
        public string GetMessage(int id)
        {
            string Output = "Not found";
            if ((id < ListOfMessages.Count) && (id >= 0))
                Output = JsonConvert.SerializeObject(ListOfMessages[id]);
            Console.WriteLine($"Message № {id} : {Output}");
            return Output;
        }

        [HttpPost]
        public IActionResult SendMessage([FromBody] MessageClass msg)
        {
            if (msg == null)
                return BadRequest();
            ListOfMessages.Add(msg);
            Console.WriteLine($"Count messages: {ListOfMessages.Count} Sended message: {msg}");
            return new OkResult();
        }
    }
}