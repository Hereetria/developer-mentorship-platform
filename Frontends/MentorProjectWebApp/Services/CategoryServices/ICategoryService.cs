namespace MentorProjectWebApp.Services.CategoryServices
{
    using MentorProjectWebApp.Dtos.CategoryDtos;
    using MentorProjectWebApp.Repositories;

    public interface ICategoryService : IGenericRepository<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>
    {
    }

}
