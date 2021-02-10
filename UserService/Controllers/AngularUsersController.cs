using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Models;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AngularUsersController : ControllerBase
    {
        public IActionResult GetAll()
        {
            var allUsers = (new UserRepository()).GetAllUsers();
            return Ok(allUsers);
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            var result = (new UserRepository()).CreateUser(user);
            return Ok(result);
        }
    }
}
