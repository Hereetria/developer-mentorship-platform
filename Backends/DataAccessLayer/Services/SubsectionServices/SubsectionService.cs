

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.SubsectionDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.SubsectionServices;

namespace DataAccessLayer.Services.SubsectionServices
{
    
    public class SubsectionService : GenericRepository<Subsection, CreateSubsectionDto, UpdateSubsectionDto, ResultSubsectionDto, ResultSubsectionByIdDto, int>, ISubsectionService

    {

        public SubsectionService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}