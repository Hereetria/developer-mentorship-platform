using MentorProjectWebApp.Dtos.MentorDtos;
using MentorProjectWebApp.Dtos.MentorSocialMediaDtos;
using MentorProjectWebApp.Dtos.SocialMediaDtos;
using MentorProjectWebApp.Repositories.Abstract;

namespace MentorProjectWebApp.Services.MentorSocialMediaServices
{
    public interface IMentorSocialMediaService : IGenericJunctionRepository<ResultMentorSocialMediaDto, CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto>
    {
        Task<List<ResultMentorDto>> GetMentorListBySocialMediaIdAsync(int socialMediaId);
        Task<List<ResultSocialMediaDto>> GetSocialMediaListByMentorIdAsync(int mentorId);
        Task DeleteMentorSocialMediaAsync(DeleteMentorSocialMediaDto deleteDto);
    }
}
