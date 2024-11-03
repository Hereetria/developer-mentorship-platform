using MentorProjectWebApp.Dtos.SkillDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.SkillServices
{
    public class SkillService : GenericRepository<CreateSkillDto, UpdateSkillDto, ResultSkillDto, ResultSkillByIdDto, int>, ISkillService
    {
        public SkillService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "skills")
        {
        }
    }
}
