

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.EngagementDtos;

namespace DataAccessLayer.Services.FeatureServices
{

    public class EngagementDAL : GenericRepositoryDAL<Engagement, CreateEngagementDto, UpdateEngagementDto, ResultEngagementDto, ResultEngagementByIdDto, int>, IEngagementDAL

    {

        public EngagementDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}