using System;
using Domain;
using Service.Interfaces;

namespace Repo;

public class CommentRepo : ICommentRepo
{
    private readonly DBContext _dbContext;

    public CommentRepo(DBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Comment> GetArticleComments(uint articleId)
    {
        List<Comment> comments = _dbContext.Comment.Where(c => c.ArticleId == articleId).ToList();

        return comments;
    }

    public Comment CreateComment(Comment comment)
    {
        _dbContext.Comment.Add(comment);
        _dbContext.SaveChanges();

        return comment;
    }

    public void DeleteComment(uint commentId)
    {
        var comment = _dbContext.Comment.FirstOrDefault(c => c.Id == commentId);
        if (comment != null)
        {
            _dbContext.Comment.Remove(comment);
            _dbContext.SaveChanges();
        }
    }

    public void UpdateComment(Comment comment)
    {
        _dbContext.Comment.Update(comment);
        _dbContext.SaveChanges();
    }
}
