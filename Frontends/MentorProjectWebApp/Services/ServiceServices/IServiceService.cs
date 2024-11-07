namespace MentorProjectWebApp.Services.ServiceServices
{
    using MentorProjectWebApp.Dtos.ServiceDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface IServiceService : IGenericRepository<CreateServiceDto, UpdateServiceDto, ResultServiceDto, ResultServiceByIdDto, int>
    {
    }

}
