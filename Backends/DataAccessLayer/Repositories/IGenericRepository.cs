

using DataAccessLayer.Repositories;

namespace DataAccessLayer.Repositories
{
    
    public interface IGenericRepository<TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>
        where TCreateDto : class
        where TUpdateDto : class
        where TResultDto : class
        where TResultById : class
    {

        Task<List<TResultDto>> GetAllAsync();

        Task CreateAsync(TCreateDto createDto);

        Task UpdateAsync(TUpdateDto updateDto);

        Task DeleteAsync(TKey id);

        Task<TResultById> GetByIdAsync(TKey id);
    }
}