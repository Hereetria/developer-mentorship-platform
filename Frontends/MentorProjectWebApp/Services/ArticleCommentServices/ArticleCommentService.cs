namespace MentorProjectWebApp.Services.ArticleCommentServices
{
    using MentorProjectWebApp.Dtos.ArticleCommentDtos;
    using MentorProjectWebApp.Repositories.Concrete;
    using System.Net.Http;

    public class ArticleCommentService : GenericRepository<CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>, IArticleCommentService
    {
        public ArticleCommentService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "articlecomments")
        {
        }
    }

}
