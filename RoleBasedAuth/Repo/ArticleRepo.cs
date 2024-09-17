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

        public Article CreateArticle(Article article)
        {
            _dbContext.Article.Add(article);
            _dbContext.SaveChanges();

            return article;
        }

        public void DeleteArticle(uint articleId)
        {
            var article = _dbContext.Article.Find(articleId);
            if (article != null)
            {
                _dbContext.Article.Remove(article);
            }
        }

        public List<Comment> GetArticleComments(uint articleId)
        {
            List<Comment> comments = _dbContext.Comment.Where(c => c.ArticleId == articleId).ToList();

            return comments;
        }

        public void UpdateArticle(Article article)
        {
            _dbContext.Article.Update(article);
            _dbContext.SaveChanges();
        }
    }
}
