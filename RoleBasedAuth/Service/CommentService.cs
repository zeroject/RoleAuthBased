using System;
using Domain;
using Service.Interfaces;

namespace Service;

public class CommentService : ICommentService
{
    private readonly ICommentRepo _commentRepo;

    public CommentService(ICommentRepo commentRepo)
    {
        _commentRepo = commentRepo;
    }

    public List<Comment> GetArticleComments(uint articleId)
    {
        return _commentRepo.GetArticleComments(articleId);
    }

    public Comment CreateComment(Comment comment)
    {
        return _commentRepo.CreateComment(comment);
    }

    public void DeleteComment(uint commentId)
    {
        _commentRepo.DeleteComment(commentId);
    }

    public void UpdateComment(Comment comment)
    {
        _commentRepo.UpdateComment(comment);
    }
    
}
