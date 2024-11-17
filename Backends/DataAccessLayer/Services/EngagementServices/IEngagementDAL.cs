
using DtoLayer.Dtos.FeatureDtos;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.EngagementDtos;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.FeatureServices
{

    public interface IEngagementDAL : IGenericRepositoryDAL<Engagement, CreateEngagementDto, UpdateEngagementDto, ResultEngagementDto, ResultEngagementByIdDto, int>

    {

    }
}