using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Repositories
{
    public abstract class GenericRepository<TCreateDto, TUpdateDto, TResultDto, TResultByIdDto, TKey> : IGenericRepository<TCreateDto, TUpdateDto, TResultDto, TResultByIdDto, TKey>
        where TCreateDto : class
        where TUpdateDto : class
        where TResultDto : class
        where TResultByIdDto : class
    {
        protected readonly HttpClient _httpClient;
        protected readonly string _baseUrl;
        protected readonly string _baseEndpoint;

        protected GenericRepository(HttpClient httpClient, IConfiguration configuration, string baseEndpoint)
        {
            _httpClient = httpClient;

            var apiBaseUrl = configuration["ApiBaseUrl"];
            if (string.IsNullOrEmpty(apiBaseUrl))
            {
                throw new ArgumentNullException(nameof(apiBaseUrl), "API base URL is not configured.");
            }

            _baseUrl = apiBaseUrl;

            _baseEndpoint = baseEndpoint;
        }



        public async Task<List<TResultDto>> GetAllAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}/{_baseEndpoint}");
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadFromJsonAsync<List<TResultDto>>();

                return result ?? new List<TResultDto>();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"GetAllAsync failed: {ex.Message}", ex);
            }
        }

        public async Task<TResultByIdDto> GetByIdAsync(TKey id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_baseUrl}/{_baseEndpoint}/{id}");
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadFromJsonAsync<TResultByIdDto>();

                return result ?? throw new Exception($"No data found for ID {id}.");
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"GetByIdAsync failed for ID {id}: {ex.Message}", ex);
            }
        }


        public async Task CreateAsync(TCreateDto dto)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync($"{_baseUrl}/{_baseEndpoint}", dto);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"CreateAsync failed: {ex.Message}", ex);
            }
        }

        public async Task UpdateAsync(TUpdateDto dto)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}/{_baseEndpoint}", dto);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"UpdateAsync failed: {ex.Message}", ex);
            }
        }

        public async Task DeleteAsync(TKey id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{_baseUrl}/{_baseEndpoint}/{id}");
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"DeleteAsync failed for ID {id}: {ex.Message}", ex);
            }
        }
    }
}
