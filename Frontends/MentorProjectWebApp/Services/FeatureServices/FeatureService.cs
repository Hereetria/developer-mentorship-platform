namespace MentorProjectWebApp.Services.FeatureServices
{
    using MentorProjectWebApp.Dtos.FeatureDtos;
    using MentorProjectWebApp.Repositories.Concrete;
    using System.Net.Http;

    public class FeatureService : GenericRepository<CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, ResultFeatureByIdDto, int>, IFeatureService
    {
        public FeatureService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "features")
        {
        }
    }

}
