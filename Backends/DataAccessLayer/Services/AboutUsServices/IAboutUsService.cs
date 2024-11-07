
using DtoLayer.Dtos.AboutUsDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.AboutUsServices
{

    public interface IAboutUsService : IGenericRepository<CreateAboutUsDto, UpdateAboutUsDto, ResultAboutUsDto, ResultAboutUsByIdDto, int>

    {

    }
}