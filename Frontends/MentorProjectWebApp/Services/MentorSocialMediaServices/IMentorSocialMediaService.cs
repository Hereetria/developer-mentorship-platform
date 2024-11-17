using MentorProjectWebApp.Dtos.MentorDtos;
using MentorProjectWebApp.Dtos.MentorSocialMediaDtos;
using MentorProjectWebApp.Dtos.SocialMediaDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.MentorSocialMediaServices
{
    public interface IMentorSocialMediaService : IGenericRepository<CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, ResultMentorSocialMediaDto, ResultMentorSocialMediaByIdDto, int>
    {
        Task<List<ResultMentorSocialMediaWithRelationsDto>> GetMentorSocialMediaWithRelationsAsync();
        Task<ResultMentorSocialMediaWithRelationsByIdDto> GetMentorSocialMediaWithRelationsByIdAsync(int id);
        Task<List<ResultMentorDto>> GetMentorListBySocialMediaIdAsync(int id);
        Task<List<ResultSocialMediaDto>> GetSocialMediaListByMentorIdAsync(int id);
    }
}