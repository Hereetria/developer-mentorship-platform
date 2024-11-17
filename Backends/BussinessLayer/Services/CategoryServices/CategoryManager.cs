using EntityLayer.Entities;
using BussinessLayer.Repositories;
using DtoLayer.Dtos.CategoryDtos;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Factories.Abstract;

namespace BussinessLayer.Services.CategoryServices
{
    public class CategoryManager : GenericRepositoryBL<Category, CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>, ICategoryManager
    {
        public CategoryManager(IGenericRepositoryDALFactory repositoryDALFactory)
            : base(repositoryDALFactory)
        {
        }

        public async Task<List<ResultCategoryWithRelationsDto>> GetCategoryWithRelationsAsync()
        {
            var result = await GetEntitiesByQueryAsync<ResultCategoryWithRelationsDto>(
                query: q => q
                    .Include(c => c.Article)
            );

            return result;
        }

        public async Task<ResultCategoryWithRelationsByIdDto> GetCategoryWithRelationsByIdAsync(int id)
        {
            var result = await GetEntityByQueryAsync<ResultCategoryWithRelationsByIdDto>(
                query: q => q
                    .Include(c => c.Article)
                    .Where(c => c.CategoryId == id)
            );

            return result;
        }
    }
}
