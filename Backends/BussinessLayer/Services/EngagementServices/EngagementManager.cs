using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.EngagementDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.EngagementServices
{
    public class EngagementManager : GenericRepositoryBL<Engagement, CreateEngagementDto, UpdateEngagementDto, ResultEngagementDto, ResultEngagementByIdDto, int>, IEngagementManager
    {
        public EngagementManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}