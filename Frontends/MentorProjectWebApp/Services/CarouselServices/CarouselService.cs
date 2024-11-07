namespace MentorProjectWebApp.Services.CarouselServices
{
    using MentorProjectWebApp.Dtos.CarouselDtos;
    using MentorProjectWebApp.Repositories.Concrete;
    using System.Net.Http;

    public class CarouselService : GenericRepository<CreateCarouselDto, UpdateCarouselDto, ResultCarouselDto, ResultCarouselByIdDto, int>, ICarouselService
    {
        public CarouselService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "Carousels")
        {
        }
    }

}
