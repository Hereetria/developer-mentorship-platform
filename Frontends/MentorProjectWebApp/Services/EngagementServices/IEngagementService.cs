using MentorProjectWebApp.Dtos.EngagementDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.EngagementServices
{
    public interface IEngagementService : IGenericRepository<CreateEngagementDto, UpdateEngagementDto, ResultEngagementDto, ResultEngagementByIdDto, int>
    {
    }
}
