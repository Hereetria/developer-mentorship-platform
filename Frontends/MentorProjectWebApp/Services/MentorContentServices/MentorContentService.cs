namespace MentorProjectWebApp.Services.MentorContentServices
{
    using MentorProjectWebApp.Dtos.MentorContentDtos;
    using MentorProjectWebApp.Repositories;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MentorContentService : GenericRepository<CreateMentorContentDto, UpdateMentorContentDto, ResultMentorContentDto, ResultMentorContentByIdDto, int>, IMentorContentService
    {
        public MentorContentService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "mentorcontents")
        {
        }

        public Task<List<ResultMentorContentWithRelationsDto>> GetMentorContentWithRelationsAsync()
            => GetAllQueryAsync<ResultMentorContentWithRelationsDto>("GetMentorContentWithRelations");

        public Task<ResultMentorContentWithRelationsByIdDto> GetMentorContentWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultMentorContentWithRelationsByIdDto>("GetMentorContentWithRelationsById", id);

    }

}
