

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.AboutUsDtos;
using DataAccessLayer.Services.AboutUsServices;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.AboutUsServices
{

    public class AboutUsDAL : GenericRepositoryDAL<AboutUs, CreateAboutUsDto, UpdateAboutUsDto, ResultAboutUsDto, ResultAboutUsByIdDto, int>, IAboutUsDAL

    {

        public AboutUsDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}