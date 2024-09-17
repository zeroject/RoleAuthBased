using Domain;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.Helpers;

namespace WEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AuthHelpers authHelpers;
        public UserController(AuthHelpers authHelpers)
        {
            this.authHelpers = authHelpers;
        }

        [HttpGet("createUser")]
        [Middleware.RoleCheck(Domain.Enums.Roles.Writer)]
        public ActionResult<User> CreateUser(User user)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult DeleteUser(uint userId) 
        {
            return BadRequest();
        }

        [HttpGet]
        public IActionResult Login(string Username, string Password)
        {
            var token = authHelpers.GenerateJWTToken(new User { Id = 1, Password_Hashed = Password, Roles = new List<Domain.Enums.Roles>(), Username = Username});
            return Ok(token);
        }
    }
}
