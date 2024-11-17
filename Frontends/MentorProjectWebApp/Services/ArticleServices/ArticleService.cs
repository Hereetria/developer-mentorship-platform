namespace MentorProjectWebApp.Services.ArticleServices
{
    using MentorProjectWebApp.Dtos.ArticleDtos;
    using MentorProjectWebApp.Repositories;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ArticleService : GenericRepository<CreateArticleDto, UpdateArticleDto, ResultArticleDto, ResultArticleByIdDto, int>, IArticleService
    {
        public ArticleService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "articles")
        {
        }

        public Task<List<ResultArticleWithRelationsDto>> GetArticleWithRelationsAsync()
            => GetAllQueryAsync<ResultArticleWithRelationsDto>("GetArticleWithRelations");

        public Task<ResultArticleWithRelationsByIdDto> GetArticleWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultArticleWithRelationsByIdDto>("GetArticleWithRelationsById", id);

    }

}
