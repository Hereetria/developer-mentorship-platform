namespace MentorProjectWebApp.Services.ArticleServices
{
    using MentorProjectWebApp.Dtos.ArticleDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;

    public class ArticleService : GenericRepository<CreateArticleDto, UpdateArticleDto, ResultArticleDto, ResultArticleByIdDto, int>, IArticleService
    {
        public ArticleService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "articles")
        {
        }
    }

}
