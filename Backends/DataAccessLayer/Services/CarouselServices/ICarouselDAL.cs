
using DtoLayer.Dtos.CarouselDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.CarouselServices
{

    public interface ICarouselDAL : IGenericRepositoryDAL<Carousel, CreateCarouselDto, UpdateCarouselDto, ResultCarouselDto, ResultCarouselByIdDto, int>

    {

    }
}