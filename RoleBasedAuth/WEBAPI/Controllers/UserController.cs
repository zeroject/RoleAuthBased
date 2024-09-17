using Domain;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using WEBAPI.Helpers;

namespace WEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AuthHelpers authHelpers;
        private readonly IUserService _userService;
        public UserController(AuthHelpers authHelpers, IUserService userService)
        {
            this.authHelpers = authHelpers;
            _userService = userService;
        }

        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            return Ok(_userService.CreateUser(user));
        }

        [HttpDelete]
        [Middleware.RoleCheck(Domain.Enums.Roles.Editor)]
        public IActionResult DeleteUser(uint userId) 
        {
            _userService.DeleteUser(userId);
            return NoContent();
        }

        [HttpGet("Login")]
        public IActionResult Login(string Username, string Password)
        {
            User user = _userService.Login(Username, Password);
            var token = authHelpers.GenerateJWTToken(user);
            return Ok(token);
        }
    }
}
