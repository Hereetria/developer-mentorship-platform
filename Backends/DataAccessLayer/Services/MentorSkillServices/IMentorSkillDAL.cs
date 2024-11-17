using DataAccessLayer.Repositories;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.MentorSkillDtos;
using DtoLayer.Dtos.MentorSocialMediaDtos;
using DtoLayer.Dtos.SkillDtos;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.MentorSkillServices
{

    public interface IMentorSkillDAL : IGenericRepositoryDAL<MentorSkill, CreateMentorSkillDto, UpdateMentorSkillDto, ResultMentorSkillDto, ResultMentorSkillByIdDto, int>
    {
        Task<ResultMentorSkillWithRelationsByIdDto> TGetMentorSkillWithRelationsByIdAsync(int id);
        Task<List<ResultMentorSkillWithRelationsDto>> TGetMentorSkillWithRelationsAsync();
        Task<List<ResultMentorDto>> TGetMentorListBySkillIdAsync(int skillId);
        Task<List<ResultSkillDto>> TGetSkillListByMentorIdAsync(int mentorId);
        Task<List<ResultMentorSkillWithSkillByIdDto>> TGetMentorSkillWithRelationsByMentorIdAsync(int mentorId);
    }
}