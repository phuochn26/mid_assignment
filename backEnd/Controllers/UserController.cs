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
        public List<User> Create(UserDTO user)
        {
            _userService.CreateUser(user);
            return _userService.GetUsers();
        }
        [HttpPut("{id}")]
        public List<User> Update(UserDTO user, int id)
        {
            _userService.UpdateUser(user, id);
            return _userService.GetUsers();
        }
        [HttpDelete("{id}")]
        public List<User> Delete(int id)
        {
            _userService.DeleteUser(id);
            return _userService.GetUsers();
        }
    }
}