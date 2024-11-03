namespace MentorProjectWebApp.Services.MentorSocialMediaServices
{
    using MentorProjectWebApp.Dtos.MentorSocialMediaDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;

    public class MentorSocialMediaService : GenericRepository<CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, ResultMentorSocialMediaDto, ResultMentorSocialMediaByIdDto, int>, IMentorSocialMediaService
    {
        public MentorSocialMediaService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "mentorsocialmedias")
        {
        }
    }

}
