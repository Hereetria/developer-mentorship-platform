

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.CarouselDtos;
using DataAccessLayer.Services.CarouselServices;
using DataAccessLayer.Repositories.Concrete;

namespace DataAccessLayer.Services.CarouselServices
{

    public class CarouselService : GenericRepository<Carousel, CreateCarouselDto, UpdateCarouselDto, ResultCarouselDto, ResultCarouselByIdDto, int>, ICarouselService

    {

        public CarouselService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}