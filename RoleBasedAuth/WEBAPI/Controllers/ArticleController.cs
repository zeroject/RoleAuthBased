using Domain;
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
        public ActionResult<Article> CreateArticle(Article article)
        {
            return Ok();
        }

        [Authorize]
        [HttpPut]
        public ActionResult<Article> EditArticle(Article article)
        {
            return BadRequest();
        }

        [Authorize]
        [HttpDelete]
        public IActionResult DeleteArticle(uint articleId)
        {
            return BadRequest();
        }

        [Authorize]
        [HttpPost]
        public ActionResult<List<Comment>> CommentOnArticle(uint articleId)
        {
            return NoContent();
        }
    }
}
