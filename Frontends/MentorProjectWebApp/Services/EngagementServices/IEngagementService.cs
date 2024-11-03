using MentorProjectWebApp.Dtos.FeatureDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.EngagementServices
{
    public interface IEngagementService : IGenericRepository<CreateEngagementDto, UpdateEngagementDto, ResultEngagementDto, ResultEngagementByIdDto, int>
    {
    }
}
