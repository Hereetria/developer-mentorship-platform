using BussinessLayer.Repositories;
using DtoLayer.Dtos.FeatureDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.FeatureServices
{
    public interface IFeatureManager : IGenericRepositoryBL<Feature, CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, ResultFeatureByIdDto, int>
    {
        Task<List<ResultFeatureWithRelationsDto>> GetFeatureWithRelationsAsync();
        Task<ResultFeatureWithRelationsByIdDto> GetFeatureWithRelationsByIdAsync(int id);
    }
}