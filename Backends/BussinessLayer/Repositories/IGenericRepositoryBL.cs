

using BussinessLayer.Repositories;
using System.Linq.Expressions;

namespace BussinessLayer.Repositories
{
    
    public interface IGenericRepositoryBL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>
        where TEntity : class
        where TCreateDto : class
        where TUpdateDto : class
        where TResultDto : class
        where TResultById : class
    {
        Task CreateAsync(TCreateDto createDto);

        Task UpdateAsync(TUpdateDto updateDto);

        Task DeleteAsync(TKey id);

        Task<List<TResultDto>> GetAllAsync();

        Task<TResultById> GetByIdAsync(TKey id);

    }
}