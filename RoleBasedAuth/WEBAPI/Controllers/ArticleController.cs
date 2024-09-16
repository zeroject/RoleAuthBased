using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        [Authorize]
        [HttpPost("CreateArticle")]
        public IActionResult CreateArticle()
        {
            return Ok();
        }

        [Authorize]
        [HttpPut]
        public IActionResult EditArticle()
        {
            return BadRequest();
        }

        [Authorize]
        [HttpDelete]
        public IActionResult DeleteArticle()
        {
            return BadRequest();
        }

        [Authorize]
        [HttpPost]
        public IActionResult CommentOnArticle()
        {
            return NoContent();
        }
    }
}
