using BussinessLayer.Repositories;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.MentorSkillDtos;
using DtoLayer.Dtos.SkillDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.MentorSkillServices
{
    public interface IMentorSkillManager : IGenericRepositoryBL<MentorSkill, CreateMentorSkillDto, UpdateMentorSkillDto, ResultMentorSkillDto, ResultMentorSkillByIdDto, int>
    {
        Task<ResultMentorSkillWithRelationsByIdDto> GetMentorSkillWithRelationsByIdAsync(int id);
        Task<List<ResultMentorSkillWithRelationsDto>> GetMentorSkillWithRelationsAsync();

        Task<List<ResultMentorDto>> GetMentorListBySkillIdAsync(int skillId);
        Task<List<ResultSkillDto>> GetSkillListByMentorIdAsync(int mentorId);

        Task<List<ResultMentorSkillWithSkillByIdDto>> GetMentorSkillWithRelationsByMentorIdAsync(int mentorId);
    }
}