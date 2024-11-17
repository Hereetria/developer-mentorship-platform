namespace MentorProjectWebApp.Services.MentorStatisticServices
{
    using MentorProjectWebApp.Dtos.MentorStatisticDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MentorStatisticService : GenericRepository<CreateMentorStatisticDto, UpdateMentorStatisticDto, ResultMentorStatisticDto, ResultMentorStatisticByIdDto, int>, IMentorStatisticService
    {
        public MentorStatisticService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "mentorstatistics")
        {
        }

        public Task<ResultMentorStatisticByIdDto> GetStatisticByMentorId(int mentorId)
        {
            var result = GetQueryByIdAsync<ResultMentorStatisticByIdDto>("GetStatisticByMentorId", mentorId);
            return result;
        }
    }

}
