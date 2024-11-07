using MentorProjectWebApp.Dtos.MentorDtos;
using MentorProjectWebApp.Dtos.MentorSkillDtos;
using MentorProjectWebApp.Dtos.SkillDtos;
using MentorProjectWebApp.Repositories.Abstract;

namespace MentorProjectWebApp.Services.MentorSkillServices
{
    public interface IMentorSkillService : IGenericJunctionRepository<ResultMentorSkillDto, CreateMentorSkillDto, UpdateMentorSkillDto>
    {
        Task<List<ResultMentorDto>> GetMentorListSkillIdAsync(int skillId);
        Task<List<ResultSkillDto>> GetSkillListByMentorIdAsync(int mentorId);
        Task DeleteMentorSkillAsync(DeleteMentorSkillDto deleteDto);
    }
}
