using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace WEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [Authorize]
        [HttpPost]
        [Middleware.RoleCheck(Domain.Enums.Roles.Writer)]
        public ActionResult<Article> CreateArticle(Article article)
        {
            return Ok(_articleService.CreateArticle(article));
        }

        [Authorize]
        [HttpPut]
        [Middleware.RoleCheck(Domain.Enums.Roles.Editor)]
        public ActionResult<Article> EditArticle(Article article)
        {
            _articleService.UpdateArticle(article);
            return Ok();
        }

        [Authorize]
        [HttpDelete]
        [Middleware.RoleCheck(Domain.Enums.Roles.Editor)]
        public IActionResult DeleteArticle(uint articleId)
        {
            _articleService.DeleteArticle(articleId);
            return NoContent();
        }

        [Authorize]
        [HttpPost("Comment")]
        [Middleware.RoleCheck(Domain.Enums.Roles.Subscriber)]
        public ActionResult<List<Comment>> CommentOnArticle(uint articleId)
        {
            return Ok(_articleService.GetArticleComments(articleId));
        }
    }
}
