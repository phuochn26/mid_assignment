using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;
using backEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public List<User> List()
        {
            return _userService.GetUsers();
        }
        [HttpGet("{id}")]
        public User GetById(int id)
        {
            return _userService.GetUserById(id);
        }
        [HttpPost]
        public IActionResult Create(UserDTO user)
        {
            if(user == null) return BadRequest();
            if (_userService.CreateUser(user))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public IActionResult Update(UserDTO user, int id)
        {
            if (_userService.UpdateUser(user, id))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(id == 0) return BadRequest();
            if (_userService.DeleteUser(id))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}