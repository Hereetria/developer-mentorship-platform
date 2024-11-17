using DataAccessLayer.Repositories;
using DtoLayer.Dtos.FeatureDtos;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.FeatureServices
{
    public interface IFeatureDAL : IGenericRepositoryDAL<Feature, CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, ResultFeatureByIdDto, int>
    {
        Task<List<ResultFeatureWithRelationsDto>> TGetFeatureWithRelationsAsync();
        Task<ResultFeatureWithRelationsByIdDto> TGetFeatureWithRelationsByIdAsync(int id);
    }

}
