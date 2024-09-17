using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _articleService;

        public CommentController(ICommentService articleService)
        {
            _articleService = articleService;
        }

        [Authorize]
        [HttpPost("Comment")]
        [Middleware.RoleCheck(Domain.Enums.Roles.Guest)]
        public ActionResult<List<Comment>> GetComments(uint articleId)
        {
            return Ok(_articleService.GetArticleComments(articleId));
        }

        [Authorize]
        [HttpGet]
        [Middleware.RoleCheck(Domain.Enums.Roles.Subscriber)]
        public ActionResult<Comment> CreateComment(Comment comment)
        {
            return Ok(_articleService.CreateComment(comment));
        }

        [Authorize]
        [HttpDelete]
        [Middleware.RoleCheck(Domain.Enums.Roles.Editor)]
        public IActionResult DeleteComment(uint commentId)
        {
            _articleService.DeleteComment(commentId);
            return NoContent();
        }

        [Authorize]
        [HttpPut]
        [Middleware.RoleCheck(Domain.Enums.Roles.Editor)]
        public IActionResult UpdateComment(Comment comment)
        {
            _articleService.UpdateComment(comment);
            return NoContent();
        }
    }
}
