

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.CarouselDtos;
using DataAccessLayer.Services.CarouselServices;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.CarouselServices
{

    public class CarouselDAL : GenericRepositoryDAL<Carousel, CreateCarouselDto, UpdateCarouselDto, ResultCarouselDto, ResultCarouselByIdDto, int>, ICarouselDAL

    {

        public CarouselDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}