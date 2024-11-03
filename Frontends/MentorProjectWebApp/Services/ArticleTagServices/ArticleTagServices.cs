using MentorProjectWebApp.Dtos.ArticleTagDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.ArticleTagServices
{
    public class ArticleTagService : GenericRepository<CreateArticleTagDto, UpdateArticleTagDto, ResultArticleTagDto, ResultArticleTagByIdDto, int>, IArticleTagService
    {
        public ArticleTagService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "articletags")
        {
        }
    }
}
