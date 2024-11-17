using System.Linq.Expressions;

namespace DataAccessLayer.Repositories
{

    public interface IGenericRepositoryDAL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>
        where TEntity : class
        where TCreateDto : class
        where TUpdateDto : class
        where TResultDto : class
        where TResultById : class
    {

        Task<List<TResultDto>> TGetAllAsync();

        Task TCreateAsync(TCreateDto createDto);

        Task TUpdateAsync(TUpdateDto updateDto);

        Task TDeleteAsync(TKey id);

        Task<TResultById> TGetByIdAsync(TKey id);

        Task<List<TResultQueryDto>> TGetEntitiesByQueryAsync<TResultQueryDto>(
            Func<IQueryable<TEntity>, IQueryable<TEntity>> query)
            where TResultQueryDto : class;

        Task<TResultQueryDto?> TGetEntityByQueryAsync<TResultQueryDto>(
            Func<IQueryable<TEntity>, IQueryable<TEntity>> query)
            where TResultQueryDto : class;

        Task<List<TResultQueryDto>> TGetSelectedEntitiesByQueryAsync<TResultQueryDto, TResultEntity>(
            Func<IQueryable<TEntity>, IQueryable<TEntity>> query,
            Expression<Func<TEntity, TResultEntity>> selectExpression)
            where TResultQueryDto : class
            where TResultEntity : class;
    }
}