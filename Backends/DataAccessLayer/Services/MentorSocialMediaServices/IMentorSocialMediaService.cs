
using DtoLayer.Dtos.MentorSocialMediaDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.MentorSocialMediaServices
{
    
    public interface IMentorSocialMediaService : IGenericRepository<CreateMentorSocialMediaDto, UpdateMentorSocialMediaDto, ResultMentorSocialMediaDto, ResultMentorSocialMediaByIdDto, int>

    {

    }
}