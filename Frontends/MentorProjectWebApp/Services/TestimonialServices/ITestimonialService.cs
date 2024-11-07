namespace MentorProjectWebApp.Services.TestimonialServices
{
    using MentorProjectWebApp.Dtos.TestimonialDtos;
    using MentorProjectWebApp.Repositories.Abstract;

    public interface ITestimonialService : IGenericRepository<CreateTestimonialDto, UpdateTestimonialDto, ResultTestimonialDto, ResultTestimonialByIdDto, int>
    {
    }

}
