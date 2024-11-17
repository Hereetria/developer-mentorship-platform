namespace MentorProjectWebApp.Services.CategoryServices
{
    using MentorProjectWebApp.Dtos.CategoryDtos;
    using MentorProjectWebApp.Repositories;

    public interface ICategoryService : IGenericRepository<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, ResultCategoryByIdDto, int>
    {
        Task<List<ResultCategoryWithRelationsDto>> GetCategoryWithRelationsAsync();
        Task<ResultCategoryWithRelationsByIdDto> GetCategoryWithRelationsByIdAsync(int id);
    }

}
