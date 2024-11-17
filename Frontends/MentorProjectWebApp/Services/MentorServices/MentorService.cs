namespace MentorProjectWebApp.Services.MentorServices
{
    using MentorProjectWebApp.Dtos.MentorContentDtos;
    using MentorProjectWebApp.Dtos.MentorDtos;
    using MentorProjectWebApp.Repositories;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MentorService : GenericRepository<CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>, IMentorService
    {
        public MentorService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "mentors")
        {
        }

        public Task<List<ResultMentorWithRelationsDto>> GetMentorWithRelationsAsync()
            => GetAllQueryAsync<ResultMentorWithRelationsDto>("GetMentorWithRelations");

        public Task<ResultMentorWithRelationsByIdDto> GetMentorWithRelationsByIdAsync(int id)
            => 
            
            GetQueryByIdAsync<ResultMentorWithRelationsByIdDto>("GetMentorWithRelationsById", id);
    }

}
