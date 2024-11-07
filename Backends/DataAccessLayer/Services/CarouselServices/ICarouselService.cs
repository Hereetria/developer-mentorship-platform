
using DtoLayer.Dtos.CarouselDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.CarouselServices
{

    public interface ICarouselService : IGenericRepository<CreateCarouselDto, UpdateCarouselDto, ResultCarouselDto, ResultCarouselByIdDto, int>

    {

    }
}