
using DtoLayer.Dtos.CategoryDtos;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.Services.CategoryServices
{

    public interface ICategoryDAL : IGenericRepositoryDAL<Category, CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>

    {
        Task<List<ResultCategoryWithRelationsDto>> TGetCategoryWithRelationsAsync();
        Task<ResultCategoryWithRelationsByIdDto> TGetCategoryWithRelationsByIdAsync(int id);
    }
}