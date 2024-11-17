using BussinessLayer.Repositories;
using DtoLayer.Dtos.ServiceDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.ServiceServices
{
    public interface IServiceManager : IGenericRepositoryBL<Service, CreateServiceDto, UpdateServiceDto, ResultServiceDto, ResultServiceByIdDto, int>
    {
    }
}