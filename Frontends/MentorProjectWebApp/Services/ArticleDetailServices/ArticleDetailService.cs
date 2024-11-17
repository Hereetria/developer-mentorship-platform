namespace MentorProjectWebApp.Services.ArticleDetailServices
{
    using MentorProjectWebApp.Dtos.ArticleDetailDtos;
    using MentorProjectWebApp.Repositories;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ArticleDetailService : GenericRepository<CreateArticleDetailDto, UpdateArticleDetailDto, ResultArticleDetailDto, ResultArticleDetailByIdDto, int>, IArticleDetailService
    {
        public ArticleDetailService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "articledetails")
        {
        }

        public Task<List<ResultArticleDetailWithRelationsDto>> GetArticleDetailWithRelationsAsync()
            => GetAllQueryAsync<ResultArticleDetailWithRelationsDto>("GetArticleDetailWithRelations");

        public Task<ResultArticleDetailWithRelationsByIdDto> GetArticleDetailWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultArticleDetailWithRelationsByIdDto>("GetArticleDetailWithRelationsById", id);
    }

}
