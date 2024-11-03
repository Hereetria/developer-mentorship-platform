
using DtoLayer.Dtos.CategoryDtos;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Services.CategoryServices
{
    
    public interface ICategoryService : IGenericRepository<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>

    {

    }
}