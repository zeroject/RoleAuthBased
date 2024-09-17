using System;
using System.Runtime.CompilerServices;
using Domain;

namespace Service.Interfaces;

public interface IArticleRepo
{
    List<Article> GetArticles();
    Article CreateArticle(Article article);
    void DeleteArticle(uint articleId);
    void UpdateArticle(Article article);
}
