using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [Authorize]
        [HttpGet("Comment")]
        [Middleware.RoleCheck(Domain.Enums.Roles.Guest)]
        public ActionResult<List<Comment>> GetComments(uint articleId)
        {
            return Ok(_commentService.GetArticleComments(articleId));
        }

        [Authorize]
        [HttpPost]
        [Middleware.RoleCheck(Domain.Enums.Roles.Subscriber)]
        public ActionResult<Comment> CreateComment(Comment comment)
        {
            return Ok(_commentService.CreateComment(comment));
        }

        [Authorize]
        [HttpDelete]
        [Middleware.RoleCheck(Domain.Enums.Roles.Editor)]
        public IActionResult DeleteComment(uint commentId)
        {
            _commentService.DeleteComment(commentId);
            return NoContent();
        }

        [Authorize]
        [HttpPut]
        [Middleware.RoleCheck(Domain.Enums.Roles.Editor)]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentService.UpdateComment(comment);
            return NoContent();
        }
    }
}
