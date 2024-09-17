using System;
using Domain;

namespace Service.Interfaces;

public interface IArticleService
{
    Article CreateArticle(Article article);
    void DeleteArticle(uint articleId);
    void UpdateArticle(Article article);
    List<Comment> GetArticleComments(uint articleId);
}
