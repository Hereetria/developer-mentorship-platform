using AutoMapper;
using DataAccessLayer.Contexts;
using DataAccessLayer.Factories.Abstract;
using DataAccessLayer.Repositories;
using DataAccessLayer.Utilities;
using System.Linq.Expressions;

namespace BussinessLayer.Repositories
{

    public abstract class GenericRepositoryBL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>
        : IGenericRepositoryBL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>
        where TEntity : class
        where TCreateDto : class
        where TUpdateDto : class
        where TResultDto : class
        where TResultById : class
    {
        private readonly IGenericRepositoryDALFactory _repositoryDALFactory;
        protected readonly IGenericRepositoryDAL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey> _repositoryDAL;

        public GenericRepositoryBL(IGenericRepositoryDALFactory repositoryDALFactory)
        {
            _repositoryDALFactory = repositoryDALFactory;
            _repositoryDAL = _repositoryDALFactory.CreateRepositoryDAL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>();
        }

        public async Task<List<TResultDto>> GetAllAsync()
        {
            var values = await _repositoryDAL.TGetAllAsync();
            return values;
        }

        public async Task<TResultById> GetByIdAsync(TKey id)
        {
            var values = await _repositoryDAL.TGetByIdAsync(id);
            return values;
        }

        public async Task CreateAsync(TCreateDto createDto)
        {
            await _repositoryDAL.TCreateAsync(createDto);
        }

        public async Task UpdateAsync(TUpdateDto updateDto)
        {
            await _repositoryDAL.TUpdateAsync(updateDto);
        }

        public async Task DeleteAsync(TKey id)
        {
            await _repositoryDAL.TDeleteAsync(id);
        }
        protected async Task<List<TResultQueryDto>> GetEntitiesByQueryAsync<TResultQueryDto>(
            Func<IQueryable<TEntity>, IQueryable<TEntity>> query)
            where TResultQueryDto : class
        {
            var values = await _repositoryDAL.TGetEntitiesByQueryAsync<TResultQueryDto>(query);
            return values;
        }

        protected async Task<TResultQueryDto?> GetEntityByQueryAsync<TResultQueryDto>(
            Func<IQueryable<TEntity>, IQueryable<TEntity>> query)
            where TResultQueryDto : class
        {
            var values = await _repositoryDAL.TGetEntityByQueryAsync<TResultQueryDto>(query);
            return values;
        }

        protected async Task<List<TResultQueryDto>> GetSelectedEntitiesByQueryAsync<TResultQueryDto, TResultEntity>(
            Func<IQueryable<TEntity>, IQueryable<TEntity>> query,
            Expression<Func<TEntity, TResultEntity>> selectExpression)
            where TResultQueryDto : class
            where TResultEntity : class
        {
            var values = await _repositoryDAL.TGetSelectedEntitiesByQueryAsync<TResultQueryDto, TResultEntity>(query, selectExpression);
            return values;
        }
    }
}