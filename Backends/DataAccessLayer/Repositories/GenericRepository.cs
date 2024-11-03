

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Contexts;

namespace DataAccessLayer.Repositories
{
    
    public abstract class GenericRepository<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey> : IGenericRepository<TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>
        where TEntity : class
        where TCreateDto : class
        where TUpdateDto : class
        where TResultDto : class
        where TResultById : class

    {

        private readonly Context _context;
        protected readonly IMapper _mapper;

        public GenericRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<TResultDto>> GetAllAsync()
        {
            try
            {
                var entities = await _context.Set<TEntity>().ToListAsync();
                if (entities == null || entities.Count == 0)
                {
                    return new List<TResultDto>();
                }
                return _mapper.Map<List<TResultDto>>(entities);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving data: {ex.Message}");
            }
        }

        public async Task<TResultById> GetByIdAsync(TKey id)
        {
            try
            {
                if (id == null)
                {
                    throw new ArgumentNullException(nameof(id), "ID cannot be null.");
                }

                var entity = await _context.Set<TEntity>().FindAsync(id);
                if (entity == null)
                {
                    throw new KeyNotFoundException($"Record with ID {id} not found.");
                }

                return _mapper.Map<TResultById>(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving the record: {ex.Message}");
            }
        }

        public async Task CreateAsync(TCreateDto createDto)
        {
            try
            {
                if (createDto == null)
                {
                    throw new ArgumentNullException(nameof(createDto), "The entity to create cannot be null.");
                }

                var entity = _mapper.Map<TEntity>(createDto);
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception($"An error occurred while saving to the database: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while creating the entity: {ex.Message}");
            }
        }

        public async Task UpdateAsync(TUpdateDto updateDto)
        {
            try
            {
                if (updateDto == null)
                {
                    throw new ArgumentNullException(nameof(updateDto), "The entity to update cannot be null.");
                }

                var entity = _mapper.Map<TEntity>(updateDto);
                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException concurrencyEx)
            {
                throw new Exception($"Concurrency conflict occurred: {concurrencyEx.Message}");
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception($"An error occurred while updating the database: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while updating the entity: {ex.Message}");
            }
        }

        public async Task DeleteAsync(TKey id)
        {
            try
            {
                if (id == null)
                {
                    throw new ArgumentNullException(nameof(id), "ID cannot be null.");
                }

                var entity = await _context.Set<TEntity>().FindAsync(id);
                if (entity == null)
                {
                    throw new KeyNotFoundException($"Record with ID {id} not found.");
                }

                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception($"An error occurred while deleting from the database: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting the entity: {ex.Message}");
            }
        }

    }
}