using System;
using System.Runtime.CompilerServices;
using Domain;

namespace Service.Interfaces;

public interface IArticleRepo
{
    Article CreateArticle(Article article);
    void DeleteArticle(uint articleId);
    void UpdateArticle(Article article);
    List<Comment> GetArticleComments(uint articleId);
}
