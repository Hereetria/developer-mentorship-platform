namespace MentorProjectWebApp.Repositories.Abstract
{
    public interface IGenericRepository<TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>
        where TCreateDto : class
        where TUpdateDto : class
        where TResultDto : class
        where TResultById : class
    {
        Task<List<TResultDto>> GetAllAsync();

        Task CreateAsync(TCreateDto dto);

        Task UpdateAsync(TUpdateDto dto);

        Task DeleteAsync(TKey id);

        Task<TResultById> GetByIdAsync(TKey id);
    }
}
