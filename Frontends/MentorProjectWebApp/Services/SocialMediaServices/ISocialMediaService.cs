using MentorProjectWebApp.Dtos.SocialMediaDtos;
using MentorProjectWebApp.Repositories.Abstract;

namespace MentorProjectWebApp.Services.SocialMediaServices
{
    public interface ISocialMediaService : IGenericRepository<CreateSocialMediaDto, UpdateSocialMediaDto, ResultSocialMediaDto, ResultSocialMediaByIdDto, int>
    {
    }
}
