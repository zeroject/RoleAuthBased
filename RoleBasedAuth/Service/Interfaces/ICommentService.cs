using System;
using Domain;

namespace Service.Interfaces;

public interface ICommentService
{
    Comment CreateComment(Comment comment);
    void DeleteComment(uint commentId);
    void UpdateComment(Comment comment);
    List<Comment> GetArticleComments(uint articleId);
}
