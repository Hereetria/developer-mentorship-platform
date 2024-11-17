using BussinessLayer.Repositories;
using DtoLayer.Dtos.SocialMediaDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.SocialMediaServices
{
    public interface ISocialMediaManager : IGenericRepositoryBL<SocialMedia, CreateSocialMediaDto, UpdateSocialMediaDto, ResultSocialMediaDto, ResultSocialMediaByIdDto, int>
    {
        Task<List<ResultSocialMediaWithRelationsDto>> GetSocialMediaWithRelationsAsync();
        Task<ResultSocialMediaWithRelationsByIdDto> GetSocialMediaWithRelationsByIdAsync(int id);
    }
}