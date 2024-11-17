using MentorProjectWebApp.Dtos.SkillDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.SkillServices
{
    public class SkillService : GenericRepository<CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>, ISkillService
    {
        public SkillService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "skills")
        {
        }

        public Task<List<ResultSkillWithRelationsDto>> GetSkillWithRelationsAsync()
            => GetAllQueryAsync<ResultSkillWithRelationsDto>("GetSkillWithRelations");

        public Task<ResultSkillWithRelationsByIdDto> GetSkillWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultSkillWithRelationsByIdDto>("GetSkillWithRelationsById", id);

    }
}
