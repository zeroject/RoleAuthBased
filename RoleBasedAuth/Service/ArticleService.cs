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

        public void CreateArticle()
        {
            _articleRepo.CreateArticle();
        }

        public void DeleteArticle()
        {
            _articleRepo.DeleteArticle();
        }

        public void GetArticleComments()
        {
            _articleRepo.GetArticleComments();
        }

        public void UpdateArticle()
        {
            _articleRepo.UpdateArticle();
        }
    }
}
