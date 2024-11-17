using MentorProjectWebApp.Dtos.ArticleTagDtos;
using MentorProjectWebApp.Dtos.MentorDtos;
using MentorProjectWebApp.Dtos.MentorSkillDtos;
using MentorProjectWebApp.Dtos.SkillDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.MentorSkillServices
{
    public interface IMentorSkillService : IGenericRepository<CreateMentorSkillDto, UpdateMentorSkillDto, ResultMentorSkillDto, ResultMentorSkillByIdDto, int>
    {
        Task<List<ResultMentorSkillWithRelationsDto>> GetMentorSkillWithRelationsAsync();
        Task<ResultMentorSkillWithRelationsByIdDto> GetMentorSkillWithRelationsByIdAsync(int id);
        Task<List<ResultMentorDto>> GetMentorListBySkillIdAsync(int id);
        Task<List<ResultSkillDto>> GetSkillListByMentorIdAsync(int id);
        Task<List<ResultMentorSkillWithRelationsByIdDto>> GetMentorSkillWithRelationsByMentorIdAsync(int id);
    }
}
