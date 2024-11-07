namespace MentorProjectWebApp.Services.CategoryServices
{
    using MentorProjectWebApp.Dtos.CategoryDtos;
    using MentorProjectWebApp.Repositories.Concrete;
    using System.Net.Http;

    public class CategoryService : GenericRepository<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>, ICategoryService
    {
        public CategoryService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "categories")
        {
        }
    }

}
