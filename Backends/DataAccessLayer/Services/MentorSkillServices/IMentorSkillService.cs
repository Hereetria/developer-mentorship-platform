
using DtoLayer.Dtos.MentorSkillDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.MentorSkillServices
{
    
    public interface IMentorSkillService : IGenericRepository<CreateMentorSkillDto, UpdateMentorSkillDto, ResultMentorSkillDto, ResultMentorSkillByIdDto, int>

    {

    }
}