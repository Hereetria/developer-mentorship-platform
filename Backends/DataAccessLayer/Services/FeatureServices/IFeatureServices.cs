using DataAccessLayer.Repositories.Abstract;
using DtoLayer.Dtos.FeatureDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.FeatureServices
{
    public interface IFeatureService : IGenericRepository<CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, ResultFeatureByIdDto, int>
    {
    }

}
