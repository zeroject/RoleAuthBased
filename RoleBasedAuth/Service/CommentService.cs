using System;
using Domain;
using Service.Interfaces;

namespace Service;

public class CommentService : ICommentService
{
    private readonly ICommentRepo _articleRepo;

    public CommentService(ICommentRepo articleRepo)
    {
        _articleRepo = articleRepo;
    }

    public List<Comment> GetArticleComments(uint articleId)
    {
        return _articleRepo.GetArticleComments(articleId);
    }

    public Comment CreateComment(Comment comment)
    {
        return _articleRepo.CreateComment(comment);
    }

    public void DeleteComment(uint commentId)
    {
        _articleRepo.DeleteComment(commentId);
    }

    public void UpdateComment(Comment comment)
    {
        _articleRepo.UpdateComment(comment);
    }
    
}
