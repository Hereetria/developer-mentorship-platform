using AutoMapper;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.ArticleTagDtos;
using DtoLayer.Dtos.FeatureDtos;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.FeatureServices
{
    public class FeatureDAL : GenericRepositoryDAL<Feature, CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, ResultFeatureByIdDto, int>, IFeatureDAL
    {
        public FeatureDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultFeatureWithRelationsDto>> TGetFeatureWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultFeatureWithRelationsDto>(
                query: q => q
                    .Include(f => f.SubDescriptions));

            return result;
        }

        public async Task<ResultFeatureWithRelationsByIdDto> TGetFeatureWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultFeatureWithRelationsByIdDto>(
                query: q => q
                    .Include(f => f.SubDescriptions)
                    .Where(f => f.FeatureId == id)
            );

            return result;
        }
    }
}
