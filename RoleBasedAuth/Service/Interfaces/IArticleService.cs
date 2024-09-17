using System;
using Domain;

namespace Service.Interfaces;

public interface IArticleService
{
    List<Article> GetArticles();
    Article CreateArticle(Article article);
    void DeleteArticle(uint articleId);
    void UpdateArticle(Article article);
}
