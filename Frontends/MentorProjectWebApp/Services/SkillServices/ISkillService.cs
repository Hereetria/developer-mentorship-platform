using MentorProjectWebApp.Dtos.SkillDtos;
using MentorProjectWebApp.Repositories.Abstract;

namespace MentorProjectWebApp.Services.SkillServices
{
    public interface ISkillService : IGenericRepository<CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>
    {
    }
}
