using MentorProjectWebApp.Dtos.FeatureDtos;
using MentorProjectWebApp.Repositories.Abstract;

namespace MentorProjectWebApp.Services.EngagementServices
{
    public interface IEngagementService : IGenericRepository<CreateEngagementDto, UpdateEngagementDto, ResultEngagementDto, ResultEngagementByIdDto, int>
    {
    }
}
