

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.CategoryDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.CategoryServices;

namespace DataAccessLayer.Services.CategoryServices
{
    
    public class CategoryService : GenericRepository<Category, CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>, ICategoryService

    {

        public CategoryService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}