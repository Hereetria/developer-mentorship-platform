
using DtoLayer.Dtos.ServiceDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.ServiceServices
{
    
    public interface IServiceService : IGenericRepository<CreateServiceDto, UpdateServiceDto, ResultServiceDto, ResultServiceByIdDto, int>

    {

    }
}