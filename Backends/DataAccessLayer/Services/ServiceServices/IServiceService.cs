
using DtoLayer.Dtos.ServiceDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.ServiceServices
{

    public interface IServiceService : IGenericRepository<CreateServiceDto, UpdateServiceDto, ResultServiceDto, ResultServiceByIdDto, int>

    {

    }
}