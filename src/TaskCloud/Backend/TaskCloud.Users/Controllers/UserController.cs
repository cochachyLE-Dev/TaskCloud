using Microsoft.AspNetCore.Mvc;

using TaskCloud.Users.Domain.Models;
using TaskCloud.Users.Service.Contract;

namespace TaskCloud.Users.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) {
            _userService = userService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserModel model)
        {
            var result = await _userService.RegisterUserAsync(model);
            return Ok(result);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserModel model)
        {
            var result = await _userService.LoginUserAsync(model);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _userService.GetUserByIdAsync(id);
            return Ok(result);
        }
    }
}
