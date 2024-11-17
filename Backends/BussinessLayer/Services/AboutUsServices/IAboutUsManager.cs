
using BussinessLayer.Repositories;
using DtoLayer.Dtos.AboutUsDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.AboutUsServices
{
    
    public interface IAboutUsManager : IGenericRepositoryBL<AboutUs, CreateAboutUsDto, UpdateAboutUsDto, ResultAboutUsDto, ResultAboutUsByIdDto, int>

    {

    }
}