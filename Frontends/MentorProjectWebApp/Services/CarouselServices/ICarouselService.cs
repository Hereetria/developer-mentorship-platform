namespace MentorProjectWebApp.Services.CarouselServices
{
    using MentorProjectWebApp.Dtos.CarouselDtos;
    using MentorProjectWebApp.Repositories;

    public interface ICarouselService : IGenericRepository<CreateCarouselDto, UpdateCarouselDto, ResultCarouselDto, ResultCarouselByIdDto, int>
    {
    }

}
