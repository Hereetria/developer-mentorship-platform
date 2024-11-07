using MentorProjectWebApp.Dtos.SubDescriptionDtos;
using MentorProjectWebApp.Repositories.Concrete;

namespace MentorProjectWebApp.Services.SubDescriptionServices
{
    public class SubDescriptionService : GenericRepository<CreateSubDescriptionDto, UpdateSubDescriptionDto, ResultSubDescriptionDto, ResultSubDescriptionByIdDto, int>, ISubDescriptionService
    {
        public SubDescriptionService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "subDescriptions")
        {
        }
    }
}
