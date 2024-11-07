namespace MentorProjectWebApp.Services.CategoryServices
{
    using MentorProjectWebApp.Dtos.CategoryDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface ICategoryService : IGenericRepository<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>
    {
    }

}
