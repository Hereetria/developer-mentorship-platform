using BussinessLayer.Repositories;
using DtoLayer.Dtos.EngagementDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.EngagementServices
{
    public interface IEngagementManager : IGenericRepositoryBL<Engagement, CreateEngagementDto, UpdateEngagementDto, ResultEngagementDto, ResultEngagementByIdDto, int>
    {
    }
}
