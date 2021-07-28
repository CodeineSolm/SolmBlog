using SolmBlog.Domain.Repositories.Abstract;

namespace SolmBlog.Domain
{
    public class DataManager
    {
        public IArticleRepository Articles { get; set; }

        public DataManager(IArticleRepository articleRepository)
        {
            Articles = articleRepository;
        }
    }
}
