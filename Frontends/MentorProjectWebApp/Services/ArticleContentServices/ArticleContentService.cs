namespace MentorProjectWebApp.Services.ArticleContentServices
{
    using MentorProjectWebApp.Dtos.ArticleContentDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;

    public class ArticleContentService : GenericRepository<CreateArticleContentDto, UpdateArticleContentDto, ResultArticleContentDto, ResultArticleContentByIdDto, int>, IArticleContentService
    {
        public ArticleContentService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "articlecontents")
        {
        }
    }

}
