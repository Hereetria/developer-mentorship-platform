namespace MentorProjectWebApp.Services.FeatureServices
{
    using MentorProjectWebApp.Dtos.FeatureDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface IFeatureService : IGenericRepository<CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, ResultFeatureByIdDto, int>
    {
    }

}
