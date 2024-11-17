namespace MentorProjectWebApp.Services.CategoryServices
{
    using MentorProjectWebApp.Dtos.CategoryDtos;
    using MentorProjectWebApp.Repositories;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class CategoryService : GenericRepository<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>, ICategoryService
    {
        public CategoryService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "categories")
        {
        }

        public Task<List<ResultCategoryWithRelationsDto>> GetCategoryWithRelationsAsync()
            => GetAllQueryAsync<ResultCategoryWithRelationsDto>("GetCategoryWithRelations");

        public Task<ResultCategoryWithRelationsByIdDto> GetCategoryWithRelationsByIdAsync(int id)
            => GetQueryByIdAsync<ResultCategoryWithRelationsByIdDto>("GetCategoryWithRelationsById", id);

    }

}
