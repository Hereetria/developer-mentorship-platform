
using DtoLayer.Dtos.MentorSocialMediaDtos;
using DataAccessLayer.Repositories.Abstract;
using DtoLayer.Dtos.MentorDtos;
using DtoLayer.Dtos.SocialMediaDtos;

namespace DataAccessLayer.Services.MentorSocialMediaServices
{

    public interface IMentorSocialMediaService : IGenericJunctionRepository<ResultMentorSocialMediaDto, CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto>
    {
        Task<List<ResultSocialMediaDto>> GetSocialMediaListByMentorIdAsync(int mentorId);
        Task<List<ResultMentorDto>> GetMentorListBySocialMediaIdAsync(int socialMediaId);
        Task DeleteMentorSocialMediaAsync(DeleteMentorSocialMediaDto deleteDto);
    }
}