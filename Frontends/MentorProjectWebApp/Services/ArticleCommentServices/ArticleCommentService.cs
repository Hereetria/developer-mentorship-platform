namespace MentorProjectWebApp.Services.ArticleCommentServices
{
    using MentorProjectWebApp.Dtos.ArticleCommentDtos;
    using MentorProjectWebApp.Repositories;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ArticleCommentService : GenericRepository<CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>, IArticleCommentService
    {
        public ArticleCommentService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "articlecomments")
        {
        }

        public Task<List<ResultArticleCommentByIdDto>> GetArticleCommentsByArticleDetailIdAsync(int id)
        {
            var result = GetAllQueryByIdAsync<ResultArticleCommentByIdDto>("GetArticleCommentsByArticleDetailId", id);

            return result;
        }
    }
}
