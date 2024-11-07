namespace MentorProjectWebApp.Repositories.Abstract
{
    public interface IGenericJunctionRepository<TResultDto, TCreateDto, TUpdateDto>
        where TResultDto : class
        where TCreateDto : class
        where TUpdateDto : class
    {
        Task<List<TResultDto>> GetAllAsync();

        Task CreateAsync(TCreateDto createDto);

        Task UpdateAsync(TUpdateDto updateDto);
    }
}
