using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.ServiceDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.ServiceServices
{
    public class ServiceManager : GenericRepositoryBL<Service, CreateServiceDto, UpdateServiceDto, ResultServiceDto, ResultServiceByIdDto, int>, IServiceManager
    {
        public ServiceManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}