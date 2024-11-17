namespace MentorProjectWebApp.Services.AboutUsServices
{
    using MentorProjectWebApp.Dtos.AboutUsDtos;
    using MentorProjectWebApp.Repositories;
    using System.Net.Http;


    public class AboutUsService : GenericRepository<CreateAboutUsDto, UpdateAboutUsDto, ResultAboutUsDto, ResultAboutUsByIdDto, int>, IAboutUsService
    {
        public AboutUsService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "aboutuses")
        {
        }
    }


}
