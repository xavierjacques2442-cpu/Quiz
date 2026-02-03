using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz.Serivces;

namespace Quiz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerOne : ControllerBase
    {
     private readonly SerivceOne serivceOne;

    public ControllerOne(SerivceOne serivceOne)
        {
            this.serivceOne = serivceOne;
        }

        [HttpGet("Add2Numbers")]
        public IActionResult  Add2Numbers([FromQuery] int Number1, [FromQuery] int Number2 )
        {
         var result = serivceOne.Add2Numbers(Number1, Number2);
         return Ok(new(Result = result));
        }
    }
}