using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Quiz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerTwo : ControllerBase
    {
        [HttpGet("reverseit")]
        public string reverseit(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}