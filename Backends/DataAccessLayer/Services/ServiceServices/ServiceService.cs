

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ServiceDtos;
using DataAccessLayer.Services.ServiceServices;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.ServiceServices
{

    public class ServiceDAL : GenericRepositoryDAL<Service, CreateServiceDto, UpdateServiceDto, ResultServiceDto, ResultServiceByIdDto, int>, IServiceDAL

    {

        public ServiceDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}