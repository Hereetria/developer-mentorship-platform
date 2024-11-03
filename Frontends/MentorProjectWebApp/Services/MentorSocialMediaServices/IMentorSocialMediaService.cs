namespace MentorProjectWebApp.Services.MentorSocialMediaServices
{
    using MentorProjectWebApp.Dtos.MentorSocialMediaDtos;
    using MentorProjectWebApp.Repositories;

    public interface IMentorSocialMediaService : IGenericRepository<CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, ResultMentorSocialMediaDto, ResultMentorSocialMediaByIdDto, int>
    {
    }

}
