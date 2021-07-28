using SolmBlog.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using SolmBlog.Domain.Entities;
using System.Linq;
using System;

namespace SolmBlog.Domain.Repositories.EntityFramework
{
    public class EFArticleRepository : IArticleRepository
    {
        private readonly AppDbContext _context;

        public EFArticleRepository(AppDbContext context)
        {
            _context = context;
        }

        public void DeleteArticle(Guid id)
        {
            _context.Articles.Remove(new Article() { Id = id });
            _context.SaveChanges();
        }

        public Article GetArticleByCodeWord(string codeWord)
        {
            return _context.Articles.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public Article GetArticleById(Guid id)
        {
            return _context.Articles.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Article> GetArticles()
        {
            return _context.Articles;
        }

        public void SaveArticle(Article articleEntity)
        {
            if (articleEntity.Id == default)
            {
                _context.Entry(articleEntity).State = EntityState.Added;
            }
            else
            {
                _context.Entry(articleEntity).State = EntityState.Modified;
            }

            _context.SaveChanges();
        }
    }
}
