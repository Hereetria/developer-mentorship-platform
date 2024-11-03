using MentorProjectWebApp.Dtos.SkillDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.SkillServices
{
    public interface ISkillService : IGenericRepository<CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>
    {
    }
}
