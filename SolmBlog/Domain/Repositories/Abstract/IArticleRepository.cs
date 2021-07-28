using SolmBlog.Domain.Entities;
using System;
using System.Linq;

namespace SolmBlog.Domain.Repositories.Abstract
{
    public interface IArticleRepository
    {
        IQueryable<Article> GetArticles();
        Article GetArticleById(Guid id);
        Article GetArticleByCodeWord(string codeWord);
        void SaveArticle(Article entity);
        void DeleteArticle(Guid id);
    }
}
