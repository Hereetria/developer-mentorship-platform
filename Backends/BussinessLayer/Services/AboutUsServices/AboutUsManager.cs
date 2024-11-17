using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.AboutUsDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.AboutUsServices
{

    public class AboutUsManager : GenericRepositoryBL<AboutUs, CreateAboutUsDto, UpdateAboutUsDto, ResultAboutUsDto, ResultAboutUsByIdDto, int>, IAboutUsManager

    {

        public AboutUsManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }
    }
}