using Domain;
using Service.Interfaces;

namespace Repo
{
    public class ArticleRepo : IArticleRepo
    {
        private readonly DBContext _dbContext;

        public ArticleRepo(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Article> GetArticles()
        {
            return _dbContext.Article.ToList();
        }

        public Article CreateArticle(Article article)
        {
            _dbContext.Article.Add(article);
            _dbContext.SaveChanges();

            return article;
        }

        public void DeleteArticle(uint articleId)
        {
            var article = _dbContext.Article.FirstOrDefault(a => a.Id == articleId);
            if (article != null)
            {
                _dbContext.Article.Remove(article);
            }
        }

        public void UpdateArticle(Article article)
        {
            _dbContext.Article.Update(article);
            _dbContext.SaveChanges();
        }
    }
}
