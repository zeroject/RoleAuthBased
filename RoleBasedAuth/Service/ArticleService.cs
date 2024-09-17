using Domain;
using Service.Interfaces;

namespace Service
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepo _articleRepo;

        public ArticleService(IArticleRepo articleRepo)
        {
            _articleRepo = articleRepo;
        }

        public List<Article> GetArticles()
        {
            return _articleRepo.GetArticles();
        }

        public Article CreateArticle(Article article)
        {
            return _articleRepo.CreateArticle(article);
        }

        public void DeleteArticle(uint articleId)
        {
            _articleRepo.DeleteArticle(articleId);
        }

        public void UpdateArticle(Article article)
        {
            _articleRepo.UpdateArticle(article);
        }
    }
}
