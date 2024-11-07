
using DataAccessLayer.Repositories.Abstract;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.MentorSkillDtos;
using DtoLayer.Dtos.SkillDtos;

namespace DataAccessLayer.Services.MentorSkillServices
{

    public interface IMentorSkillService : IGenericJunctionRepository<ResultMentorSkillDto, CreateMentorSkillDto, UpdateMentorSkillDto>
    {
        Task<List<ResultMentorDto>> GetMentorListBySkillIdAsync(int skillId);
        Task<List<ResultSkillDto>> GetSkillListByMentorIdAsync(int mentorId);
        Task DeleteMentorSkillAsync(DeleteMentorSkillDto deleteDto);
    }
}