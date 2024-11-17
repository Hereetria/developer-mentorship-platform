namespace MentorProjectWebApp.Services.FeatureServices
{
    using MentorProjectWebApp.Dtos.FeatureDtos;
    using MentorProjectWebApp.Repositories;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class FeatureService : GenericRepository<CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, ResultFeatureByIdDto, int>, IFeatureService
    {
        public FeatureService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "features")
        {
        }

        public Task<List<ResultFeatureWithRelationsDto>> GetFeatureWithRelationsAsync()
            => GetAllQueryAsync<ResultFeatureWithRelationsDto>("GetFeatureWithRelations");

        public Task<ResultFeatureWithRelationsByIdDto> GetFeatureWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultFeatureWithRelationsByIdDto>("GetFeatureWithRelationsById", id);

    }

}
