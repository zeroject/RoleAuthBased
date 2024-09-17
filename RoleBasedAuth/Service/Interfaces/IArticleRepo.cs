using System;
using System.Runtime.CompilerServices;

namespace Service.Interfaces;

public interface IArticleRepo
{
    void CreateArticle();
    void DeleteArticle();
    void UpdateArticle();
    void GetArticleComments();
}
