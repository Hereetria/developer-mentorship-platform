using MentorProjectWebApp.Dtos.SkillDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.SkillServices
{
    public interface ISkillService : IGenericRepository<CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>
    {
        Task<List<ResultSkillWithRelationsDto>> GetSkillWithRelationsAsync();
        Task<ResultSkillWithRelationsByIdDto> GetSkillWithRelationsByIdAsync(int id);
    }
}
