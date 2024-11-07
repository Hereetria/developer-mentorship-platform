
using DtoLayer.Dtos.FeatureDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.FeatureServices
{

    public interface IEngagementService : IGenericRepository<CreateEngagementDto, UpdateEngagementDto, ResultEngagementDto, ResultEngagementByIdDto, int>

    {

    }
}