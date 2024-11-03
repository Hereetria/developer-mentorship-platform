using MentorProjectWebApp.Dtos.SocialMediaDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.SocialMediaServices
{
    public class SocialMediaService : GenericRepository<CreateSocialMediaDto, UpdateSocialMediaDto, ResultSocialMediaDto, ResultSocialMediaByIdDto, int>, ISocialMediaService
    {
        public SocialMediaService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "socialmedia")
        {
        }
    }
}
