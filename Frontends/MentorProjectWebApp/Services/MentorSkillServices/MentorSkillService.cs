namespace MentorProjectWebApp.Services.MentorSkillServices
{
    using EntityLayer.Entities;
    using MentorProjectWebApp.Dtos.MentorDtos;
    using MentorProjectWebApp.Dtos.MentorSkillDtos;
    using MentorProjectWebApp.Dtos.SkillDtos;
    using MentorProjectWebApp.Repositories;
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MentorSkillService : GenericRepository<CreateMentorSkillDto, UpdateMentorSkillDto, ResultMentorSkillDto, ResultMentorSkillByIdDto, int>, IMentorSkillService
    {
        public MentorSkillService(HttpClient httpClient, IConfiguration configuration) 
            : base(httpClient, configuration, "mentorskills")
        {
        }

        public Task<List<ResultMentorDto>> GetMentorListBySkillIdAsync(int id)
            => GetAllQueryByIdAsync<ResultMentorDto>("GetMentorListBySkillId", id);

        public Task<List<ResultSkillDto>> GetSkillListByMentorIdAsync(int id)
            => GetAllQueryByIdAsync<ResultSkillDto>("GetSkillListByMentorId", id);

        public Task<List<ResultMentorSkillWithRelationsDto>> GetMentorSkillWithRelationsAsync()
            => GetAllQueryAsync<ResultMentorSkillWithRelationsDto>("GetMentorSkillWithRelations");

        public Task<ResultMentorSkillWithRelationsByIdDto> GetMentorSkillWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultMentorSkillWithRelationsByIdDto>("GetMentorSkillWithRelationsById", id);

        public Task<List<ResultMentorSkillWithRelationsByIdDto>> GetMentorSkillWithRelationsByMentorIdAsync(int id)
            => GetAllQueryByIdAsync<ResultMentorSkillWithRelationsByIdDto>("GetMentorSkillWithRelationsByMentorId", id);
    }

}
