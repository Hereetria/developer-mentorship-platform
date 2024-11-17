namespace MentorProjectWebApp.Services.TagServices
{
    using MentorProjectWebApp.Dtos.TagDtos;
    using MentorProjectWebApp.Repositories;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class TagService : GenericRepository<CreateTagDto, UpdateTagDto, ResultTagDto, ResultTagByIdDto, int>, ITagService
    {
        public TagService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "tags")
        {
        }

        public Task<List<ResultTagWithRelationsDto>> GetTagWithRelationsAsync()
            => GetAllQueryAsync<ResultTagWithRelationsDto>("GetTagWithRelations");


        public Task<ResultTagWithRelationsByIdDto> GetTagWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultTagWithRelationsByIdDto>("GetTagWithRelationsById", id);
    }
}
