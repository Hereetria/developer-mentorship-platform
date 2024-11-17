using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.FeatureDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.FeatureServices
{
    public class FeatureManager : GenericRepositoryBL<Feature, CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, ResultFeatureByIdDto, int>, IFeatureManager
    {
        public FeatureManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultFeatureWithRelationsDto>> GetFeatureWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultFeatureWithRelationsDto>(
                query: q => q
                    .Include(f => f.SubDescriptions));

            return result;
        }

        public async Task<ResultFeatureWithRelationsByIdDto> GetFeatureWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultFeatureWithRelationsByIdDto>(
                query: q => q
                    .Include(f => f.SubDescriptions)
                    .Where(f => f.FeatureId == id)
            );

            return result;
        }
    }
}