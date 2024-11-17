using MentorProjectWebApp.Dtos.EngagementDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.EngagementServices
{
    public class EngagementService : GenericRepository<CreateEngagementDto, UpdateEngagementDto, ResultEngagementDto, ResultEngagementByIdDto, int>, IEngagementService
    {
        public EngagementService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "engagements")
        {
        }
    }
}
