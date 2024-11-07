
using DtoLayer.Dtos.CategoryDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.CategoryServices
{

    public interface ICategoryService : IGenericRepository<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>

    {

    }
}