namespace MentorProjectWebApp.Services.ServiceServices
{
    using MentorProjectWebApp.Dtos.ServiceDtos;
    using MentorProjectWebApp.Repositories.Concrete;
    using System.Net.Http;

    public class ServiceService : GenericRepository<CreateServiceDto, UpdateServiceDto, ResultServiceDto, ResultServiceByIdDto, int>, IServiceService
    {
        public ServiceService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "services")
        {
        }
    }

}
