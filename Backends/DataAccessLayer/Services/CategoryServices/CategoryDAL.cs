

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.CategoryDtos;
using DataAccessLayer.Services.CategoryServices;
using DataAccessLayer.Repositories;
using DtoLayer.Dtos.FeatureDtos;
using Microsoft.EntityFrameworkCore;
using DtoLayer.Dtos.ArticleTagDtos;

namespace DataAccessLayer.Services.CategoryServices
{

    public class CategoryDAL : GenericRepositoryDAL<Category, CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>, ICategoryDAL

    {

        public CategoryDAL(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<List<ResultCategoryWithRelationsDto>> TGetCategoryWithRelationsAsync()
        {
            var result = await TGetEntitiesByQueryAsync<ResultCategoryWithRelationsDto>(
                query: q => q
                    .Include(c => c.Article)
            );

            return result;
        }

        public async Task<ResultCategoryWithRelationsByIdDto> TGetCategoryWithRelationsByIdAsync(int id)
        {
            var result = await TGetEntityByQueryAsync<ResultCategoryWithRelationsByIdDto>(
                query: q => q
                    .Include(c => c.Article)
                    .Where(c => c.CategoryId == id)
            );

            return result;
        }
    }
}