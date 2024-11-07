namespace MentorProjectWebApp.Services.AboutUsServices
{
    using MentorProjectWebApp.Dtos.AboutUsDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface IAboutUsService : IGenericRepository<CreateAboutUsDto, UpdateAboutUsDto, ResultAboutUsDto, ResultAboutUsByIdDto, int>
    {
    }

}
