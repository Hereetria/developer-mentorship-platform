namespace MentorProjectWebApp.Services.TestimonialServices
{
    using MentorProjectWebApp.Dtos.TestimonialDtos;
    using MentorProjectWebApp.Repositories;

    public interface ITestimonialService : IGenericRepository<CreateTestimonialDto, UpdateTestimonialDto, ResultTestimonialDto, ResultTestimonialByIdDto, int>
    {
    }

}
