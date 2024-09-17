using System;

namespace Service.Interfaces;

public interface IArticleService
{
    void CreateArticle();
    void DeleteArticle();
    void UpdateArticle();
    void GetArticleComments();
}
