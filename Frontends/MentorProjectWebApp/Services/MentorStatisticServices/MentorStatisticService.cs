namespace MentorProjectWebApp.Services.MentorStatisticServices
{
    using MentorProjectWebApp.Dtos.MentorStatisticDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;

    public class MentorStatisticService : GenericRepository<CreateMentorStatisticDto, UpdateMentorStatisticDto, ResultMentorStatisticDto, ResultMentorStatisticByIdDto, int>, IMentorStatisticService
    {
        public MentorStatisticService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "mentorstatistics")
        {
        }
    }

}
