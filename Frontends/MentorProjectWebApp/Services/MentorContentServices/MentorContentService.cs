namespace MentorProjectWebApp.Services.MentorContentServices
{
    using MentorProjectWebApp.Dtos.MentorContentDtos;
    using MentorProjectWebApp.Repositories.Concrete;
    using System.Net.Http;

    public class MentorContentService : GenericRepository<CreateMentorContentDto, UpdateMentorContentDto, ResultMentorContentDto, ResultMentorContentByIdDto, int>, IMentorContentService
    {
        public MentorContentService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "mentorcontents")
        {
        }
    }

}
