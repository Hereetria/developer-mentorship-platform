

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.FeatureDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.FeatureServices
{
    
    public class EngagementService : GenericRepository<Engagement, CreateEngagementDto, UpdateEngagementDto, ResultEngagementDto, ResultEngagementByIdDto, int>, IEngagementService

    {

        public EngagementService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}