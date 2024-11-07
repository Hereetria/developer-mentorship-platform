namespace MentorProjectWebApp.Services.TestimonialServices
{
    using MentorProjectWebApp.Dtos.TestimonialDtos;
    using MentorProjectWebApp.Repositories.Concrete;
    using System.Net.Http;

    public class TestimonialService : GenericRepository<CreateTestimonialDto, UpdateTestimonialDto, ResultTestimonialDto, ResultTestimonialByIdDto, int>, ITestimonialService
    {
        public TestimonialService(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration, "testimonials")
        {
        }
    }

}
