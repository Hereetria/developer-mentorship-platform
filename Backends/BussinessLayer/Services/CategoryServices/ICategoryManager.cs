using BussinessLayer.Repositories;
using DtoLayer.Dtos.CategoryDtos;
using EntityLayer.Entities;

namespace BussinessLayer.Services.CategoryServices
{
    public interface ICategoryManager : IGenericRepositoryBL<Category, CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>
    {
        Task<List<ResultCategoryWithRelationsDto>> GetCategoryWithRelationsAsync();
        Task<ResultCategoryWithRelationsByIdDto> GetCategoryWithRelationsByIdAsync(int id);
    }
}