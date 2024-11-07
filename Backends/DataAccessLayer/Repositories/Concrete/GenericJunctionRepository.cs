using AutoMapper;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repositories.Abstract;
using DtoLayer.Dtos.MentorSkillDtos;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessLayer.Repositories.Concrete
{
    public abstract class GenericJunctionRepository<TEntity, TResultDto, TCreateDto, TUpdateDto, TKey> : IGenericJunctionRepository<TResultDto, TCreateDto, TUpdateDto>
        where TEntity : class
        where TResultDto : class
        where TCreateDto : class
        where TUpdateDto : class
    {
        protected readonly Context _context;
        protected readonly IMapper _mapper;
        public GenericJunctionRepository(Context context, IMapper mapper)
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

                var result = _mapper.Map<List<TResultDto>>(entities);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving all mentor skills: {ex.Message}");
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

        protected async Task DeleteAsync(
            Expression<Func<TEntity, bool>> idSelector)
        {
            try
            {
                var entity = await _context.Set<TEntity>()
                    .FirstOrDefaultAsync(idSelector);

                if (entity == null)
                {
                    throw new KeyNotFoundException($"No record found with the provided keys.");
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


        protected async Task<List<TRelatedEntity>> GetRelatedEntitiesByIdAsync<TRelatedEntity>(
            TKey entityId,
            Expression<Func<TEntity, bool>> entityFilter,
            Expression<Func<TEntity, TRelatedEntity>> relatedEntitySelector)
        {
            try
            {
                var relatedEntities = await _context.Set<TEntity>()
                    .Where(entityFilter)
                    .Select(relatedEntitySelector)
                    .ToListAsync();

                return relatedEntities;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred during data extraction: {ex.Message}");
            }
        }
    }
}
