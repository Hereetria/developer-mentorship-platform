

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.SubsectionDtos;
using DataAccessLayer.Services.SubsectionServices;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.SubsectionServices
{

    public class SubsectionDAL : GenericRepositoryDAL<Subsection, CreateSubsectionDto, UpdateSubsectionDto, ResultSubsectionDto, ResultSubsectionByIdDto, int>, ISubsectionDAL

    {

        public SubsectionDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}