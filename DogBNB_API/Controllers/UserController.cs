using DogBNB.Models;
using DogBNB.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DogBNB_API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("add")]
        public User CreateUser([FromBody]User user)
        {
            return _userService.CreateUser(user);
        }
        [HttpDelete ("delete/{id}")]
        public void DeleteUser(int id)
        {
            _userService.DeleteUser(id);
        }
        [HttpGet ("{id}")]
        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }
        [HttpGet]
        public List<User> GetUsers()
        {
            return _userService.GetUsers();
        }
        [HttpGet ("users-by-name/{username}")]
        public List<User> GetUsersByName(string username)
        {
            return _userService.GetUsersByName(username);
        }
        [HttpPut("edit/{id}")]
        public User UpdateUser([FromBody]User user, int id)
        {
            return _userService.UpdateUser(user, id);
        }

    }
}
