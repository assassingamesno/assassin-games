using assassingames_backend.DTOs.Mappers;
using assassingames_backend.Models;
using assassingames_backend.Models.DTOs;
using assassingames_backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assassingames_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class UserController: Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            IEnumerable<User> users = _userService.GetUsers();
            return Ok(UserMapper.GetUsers(users));
        }
        [HttpGet("{userId}")]
        public IActionResult GetUser(Guid userId)
        {
            User user = _userService.GetUser(userId);
            return user == null ? NotFound() : Ok(UserMapper.GetUser(user));
        }
        [HttpPost]
        public IActionResult InsertUser([FromBody] User user)
        {
            if (!ModelState.IsValid || 
                !user.EMail.Contains("@"))
                return BadRequest();
            _userService.InsertUser(user);
            return Created("~api/User/"+user.UserId.ToString(), user);
        }
        [HttpPut]
        public IActionResult UpdateUser([FromBody]User user)
        {
            _userService.UpdateUser(user);
            return Ok();
        }
        [HttpDelete("{userId}")]
        public IActionResult DeleteUser(Guid userId)
        {
            _userService.DeleteUser(userId);
            return Ok();
        }
    }
}
