

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ServiceDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.ServiceServices;

namespace DataAccessLayer.Services.ServiceServices
{
    
    public class ServiceService : GenericRepository<Service, CreateServiceDto, UpdateServiceDto, ResultServiceDto, ResultServiceByIdDto, int>, IServiceService

    {

        public ServiceService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}