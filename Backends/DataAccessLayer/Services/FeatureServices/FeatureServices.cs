using AutoMapper;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repositories.Concrete;
using DtoLayer.Dtos.FeatureDtos;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.FeatureServices
{
    public class FeatureService : GenericRepository<Feature, CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, ResultFeatureByIdDto, int>, IFeatureService
    {
        public FeatureService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }

}
