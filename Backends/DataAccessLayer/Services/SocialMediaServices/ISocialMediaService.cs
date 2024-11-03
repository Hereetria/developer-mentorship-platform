
using DtoLayer.Dtos.SocialMediaDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.SocialMediaServices
{
    
    public interface ISocialMediaService : IGenericRepository<CreateSocialMediaDto, UpdateSocialMediaDto, ResultSocialMediaDto, ResultSocialMediaByIdDto, int>

    {

    }
}