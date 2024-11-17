using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.CarouselDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.CarouselServices
{
    public class CarouselManager : GenericRepositoryBL<Carousel, CreateCarouselDto, UpdateCarouselDto, ResultCarouselDto, ResultCarouselByIdDto, int>, ICarouselManager
    {
        public CarouselManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}