
using DtoLayer.Dtos.AboutUsDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.AboutUsServices
{

    public interface IAboutUsDAL : IGenericRepositoryDAL<AboutUs, CreateAboutUsDto, UpdateAboutUsDto, ResultAboutUsDto, ResultAboutUsByIdDto, int>

    {

    }
}