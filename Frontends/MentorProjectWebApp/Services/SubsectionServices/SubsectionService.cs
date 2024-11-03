namespace MentorProjectWebApp.Services.SubsectionServices
{
    using MentorProjectWebApp.Dtos.SubsectionDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;

    public class SubsectionService : GenericRepository<CreateSubsectionDto, UpdateSubsectionDto, ResultSubsectionDto, ResultSubsectionByIdDto, int>, ISubsectionService
    {
        public SubsectionService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "subsections")
        {
        }
    }

}
