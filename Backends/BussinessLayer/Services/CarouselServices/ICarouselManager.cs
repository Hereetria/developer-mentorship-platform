using BussinessLayer.Repositories;
using DtoLayer.Dtos.CarouselDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.CarouselServices
{
    public interface ICarouselManager : IGenericRepositoryBL<Carousel, CreateCarouselDto, UpdateCarouselDto, ResultCarouselDto, ResultCarouselByIdDto, int>
    {
    }
}