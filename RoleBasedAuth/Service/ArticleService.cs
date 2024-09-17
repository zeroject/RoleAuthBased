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

        public Article CreateArticle(Article article)
        {
            return _articleRepo.CreateArticle(article);
        }

        public void DeleteArticle(uint articleId)
        {
            _articleRepo.DeleteArticle(articleId);
        }

        public List<Comment> GetArticleComments(uint articleId)
        {
            return _articleRepo.GetArticleComments(articleId);
        }

        public void UpdateArticle(Article article)
        {
            _articleRepo.UpdateArticle(article);
        }
    }
}
