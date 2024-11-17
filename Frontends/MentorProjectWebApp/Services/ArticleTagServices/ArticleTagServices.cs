using MentorProjectWebApp.Dtos.ArticleDetailDtos;
using MentorProjectWebApp.Dtos.ArticleTagDtos;
using MentorProjectWebApp.Dtos.TagDtos;
using MentorProjectWebApp.Repositories;
using System.Net.Http;
using System.Reflection;

namespace MentorProjectWebApp.Services.ArticleTagServices
{
    public class ArticleTagService : GenericRepository<CreateArticleTagDto, UpdateArticleTagDto, ResultArticleTagDto, ResultArticleTagByIdDto, int>, IArticleTagService
    {
        public ArticleTagService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "articletags")
        {
        }

        public Task<List<ResultArticleDetailDto>> GetArticleDetailListByTagIdAsync(int id)
            => GetAllQueryByIdAsync<ResultArticleDetailDto>("GetArticleDetailListByTagId", id);

        public Task<List<ResultTagDto>> GetTagListByArticleIdAsync(int id)
            => GetAllQueryByIdAsync<ResultTagDto>("GetTagListByArticleId", id);

        public Task<List<ResultArticleTagWithRelationsDto>> GetArticleTagWithRelationsAsync()
            => GetAllQueryAsync<ResultArticleTagWithRelationsDto>("GetArticleTagWithRelations");

        public Task<ResultArticleTagWithRelationsByIdDto> GetArticleTagWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultArticleTagWithRelationsByIdDto>("GetArticleTagWithRelationsById", id);
    }
}
