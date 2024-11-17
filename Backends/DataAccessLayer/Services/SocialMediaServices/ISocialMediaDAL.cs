
using DtoLayer.Dtos.SocialMediaDtos;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.SkillDtos;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.SocialMediaServices
{

    public interface ISocialMediaDAL : IGenericRepositoryDAL<SocialMedia, CreateSocialMediaDto, UpdateSocialMediaDto, ResultSocialMediaDto, ResultSocialMediaByIdDto, int>

    {
        Task<List<ResultSocialMediaWithRelationsDto>> TGetSocialMediaWithRelationsAsync();
        Task<ResultSocialMediaWithRelationsByIdDto> TGetSocialMediaWithRelationsByIdAsync(int id);
    }
}