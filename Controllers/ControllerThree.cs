using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Quiz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerThree : ControllerBase
    {
         [HttpGet("SayHello")] 
       public string SayHello([FromQuery] string name)
        {
           return $"Hello {name}!"  ;
        }
    }
}