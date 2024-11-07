

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.SubsectionDtos;
using DataAccessLayer.Services.SubsectionServices;
using DataAccessLayer.Repositories.Concrete;

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