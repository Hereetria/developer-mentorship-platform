using System.Net;

namespace MentorProjectWebApp.Handlers
{
    public class HttpClientErrorHandler : DelegatingHandler
    {
        private readonly ILogger<HttpClientErrorHandler> _logger;

        public HttpClientErrorHandler(ILogger<HttpClientErrorHandler> logger)
        {
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;
            try
            {
                response = await base.SendAsync(request, cancellationToken);

                if (!response.IsSuccessStatusCode)
                {
                    await HandleErrorAsync(request, response);
                }

                return response;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "An error occurred while sending request to {RequestUri}.", request.RequestUri);
                throw new HttpRequestException("A network error occurred while processing your request.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred.");
                throw new Exception("An unexpected error occurred while processing your request.");
            }
        }

        private async Task HandleErrorAsync(HttpRequestMessage request, HttpResponseMessage response)
        {
            _logger.LogWarning("Request to {RequestUri} failed with status code {StatusCode}", request.RequestUri, response.StatusCode);

            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    _logger.LogInformation("Resource not found: {RequestUri}", request.RequestUri);
                    break;
                case HttpStatusCode.InternalServerError:
                    _logger.LogError("Internal server error occurred when accessing {RequestUri}", request.RequestUri);
                    break;
                case HttpStatusCode.BadRequest:
                    _logger.LogWarning("Bad request to {RequestUri}", request.RequestUri);
                    break;
                case HttpStatusCode.Unauthorized:
                    _logger.LogWarning("Unauthorized access to {RequestUri}", request.RequestUri);
                    break;
                default:
                    _logger.LogWarning("Request to {RequestUri} failed with status code {StatusCode}.", request.RequestUri, response.StatusCode);
                    break;
            }

            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new HttpRequestException("There was a problem with the server. Please try again later.");
            }
        }
    }

}
