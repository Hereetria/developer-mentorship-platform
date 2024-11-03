namespace MentorProjectWebApp.Services.ArticleDetailServices
{
    using MentorProjectWebApp.Dtos.ArticleDetailDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;

    public class ArticleDetailService : GenericRepository<CreateArticleDetailDto, UpdateArticleDetailDto, ResultArticleDetailDto, ResultArticleDetailByIdDto, int>, IArticleDetailService
    {
        public ArticleDetailService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "articledetails")
        {
        }
    }

}
