using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rover.Interfaces;
using Rover.ServiceInterfaces;
using Rover.Services;

namespace Rover.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpDelete("{userId:int}")]
        public async Task<IActionResult> DeleteUser([FromServices] IUserService userService, int userId)
        {
            if (userId == 0)
            {
                return BadRequest();
            }

            await userService.RemoveUser(userId);
            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById([FromServices] IUserService userService,int userId)
        {
            if (userId == 0)
            {
                return BadRequest();
            }

            await userService.GetUserById(userId);
        }
        
        
        
        
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }
        
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

    }
}