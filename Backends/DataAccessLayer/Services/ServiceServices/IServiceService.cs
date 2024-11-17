
using DtoLayer.Dtos.ServiceDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.ServiceServices
{

    public interface IServiceDAL : IGenericRepositoryDAL<Service, CreateServiceDto, UpdateServiceDto, ResultServiceDto, ResultServiceByIdDto, int>

    {

    }
}