namespace MentorProjectWebApp.Services.MentorServices
{
    using MentorProjectWebApp.Dtos.MentorDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;

    public class MentorService : GenericRepository<CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>, IMentorService
    {
        public MentorService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "mentors")
        {
        }
    }

}
